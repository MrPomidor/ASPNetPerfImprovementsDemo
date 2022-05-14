using NBomber.Configuration;
using NBomber.Contracts;
using NBomber.CSharp;
using Serilog;
using Newtonsoft.Json;

const string baseUrl = "https://localhost:44390/customer";

using var httpClient = new HttpClient();


var orderIdsFeed = await GetOrderIdsFeed(httpClient);
var productIdsFeed = await GetProductIdsFeed(httpClient);

var clientFactory = ClientFactory.Create(
    name: "http_factory",
    clientCount: 30,
    initClient: (number, context) => Task.FromResult(new HttpClient()));

var getOrdersPageStep = Step.Create("getOrdersPage", clientFactory, orderIdsFeed, (context) =>
{
    return GetResourse(context.Client, "orders", id: context.FeedItem, context.Logger);
});

var getProductsPageStep = Step.Create("getProductsPage", clientFactory, productIdsFeed, (context) =>
{
    return GetResourse(context.Client, "products", id: context.FeedItem, context.Logger);
});

var ordersScenario = ScenarioBuilder.CreateScenario("Orders", getOrdersPageStep)
    .WithWarmUpDuration(TimeSpan.FromSeconds(10))
    .WithLoadSimulations(
        LoadSimulation.NewKeepConstant(_copies: 7, _during: TimeSpan.FromMinutes(3))
    );

var productsScenario = ScenarioBuilder.CreateScenario("Products", getProductsPageStep)
    .WithWarmUpDuration(TimeSpan.FromSeconds(10))
    .WithLoadSimulations(
        LoadSimulation.NewKeepConstant(_copies: 7, _during: TimeSpan.FromMinutes(3))
    );

NBomberRunner
    .RegisterScenarios(ordersScenario, productsScenario)
    .WithReportFormats(ReportFormat.Html, ReportFormat.Md)
    .Run();

Console.WriteLine("Press any key ...");
Console.ReadKey();



Task<IFeed<int>> GetOrderIdsFeed(HttpClient client)
{
    return GetResourseIdsFeed(client, "orders", "ordersIds");
}

Task<IFeed<int>> GetProductIdsFeed(HttpClient client)
{
    return GetResourseIdsFeed(client, "products", "productsIds");
}

async Task<IFeed<int>> GetResourseIdsFeed(HttpClient client, string resourse, string feedName)
{
    var countResponse = await client.GetAsync($"{baseUrl}/{resourse}/ids");
    if (!countResponse.IsSuccessStatusCode)
        throw new ApplicationException("Unable to get count");

    var ids = JsonConvert.DeserializeObject<int[]>(await countResponse.Content.ReadAsStringAsync());
    return Feed.CreateCircular(feedName, ids);
}

async Task<Response> GetResourse(HttpClient client, string resourse, int id, ILogger logger = null)
{
    var response = await client.GetAsync($"{baseUrl}/{resourse}/{id}");
    if (response.IsSuccessStatusCode)
        return Response.Ok(statusCode: (int)response.StatusCode);
    else
    {
        if (logger != null)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            logger.Error(responseContent);
        }
        return Response.Fail(statusCode: (int)response.StatusCode, error: response.ReasonPhrase);
    }
}
