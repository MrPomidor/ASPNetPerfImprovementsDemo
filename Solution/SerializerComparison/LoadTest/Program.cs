using NBomber.Configuration;
using NBomber.Contracts;
using NBomber.CSharp;
using Serilog;
using Newtonsoft.Json;

const int pageSize = 100;
const string baseUrl = "https://localhost:44390/customer";

using var httpClient = new HttpClient();


var orderIdsFeed = await GetOrderIdsFeed(httpClient);
var orderPageNumbersFeed = await GetOrdersPageNumberFeed(httpClient);

var clientFactory = ClientFactory.Create(
    name: "http_factory",
    clientCount: 30,
    initClient: (number, context) => Task.FromResult(new HttpClient()));

var getOrderStep = Step.Create("getOrder", clientFactory, orderIdsFeed, (context) =>
{
    return GetResourse(context.Client, "orders", id: context.FeedItem, context.Logger);
});

var getOrdersPageStep = Step.Create("getOrdersPage", clientFactory, orderPageNumbersFeed, (context) =>
{
    return GetResoursePage(context.Client, "orders", pageNumber: context.FeedItem);
});

var ordersScenario = ScenarioBuilder.CreateScenario("Orders by Id", getOrderStep)
    .WithWarmUpDuration(TimeSpan.FromSeconds(10))
    .WithLoadSimulations(
        LoadSimulation.NewKeepConstant(_copies: 10, _during: TimeSpan.FromMinutes(3))
    );

var ordersPageScenario = ScenarioBuilder.CreateScenario("Orders page", getOrdersPageStep)
    .WithWarmUpDuration(TimeSpan.FromSeconds(10))
    .WithLoadSimulations(
        LoadSimulation.NewKeepConstant(_copies: 10, _during: TimeSpan.FromMinutes(3))
    );

NBomberRunner
    .RegisterScenarios(ordersScenario, ordersPageScenario)
    .WithReportFormats(ReportFormat.Html, ReportFormat.Md)
    .Run();

Console.WriteLine("Press any key ...");
Console.ReadKey();



Task<IFeed<int>> GetOrderIdsFeed(HttpClient client)
{
    return GetResourseIdsFeed(client, "orders", "ordersIds");
}

async Task<IFeed<int>> GetResourseIdsFeed(HttpClient client, string resourse, string feedName)
{
    var countResponse = await client.GetAsync($"{baseUrl}/{resourse}/ids");
    if (!countResponse.IsSuccessStatusCode)
        throw new ApplicationException("Unable to get count");

    var ids = JsonConvert.DeserializeObject<int[]>(await countResponse.Content.ReadAsStringAsync());
    return Feed.CreateCircular(feedName, ids);
}

Task<IFeed<int>> GetOrdersPageNumberFeed(HttpClient client)
{
    return GetPageNumberFeed(client, "/orders/count", "ordersPageNumbers");
}

async Task<IFeed<int>> GetPageNumberFeed(HttpClient client, string countRoute, string feedName)
{
    var countResponse = await client.GetAsync($"{baseUrl}{countRoute}");
    if (!countResponse.IsSuccessStatusCode)
        throw new ApplicationException("Unable to get count");

    var totalAmount = int.Parse(await countResponse.Content.ReadAsStringAsync());
    var pages = totalAmount / pageSize;
    pages = pages == (totalAmount * pageSize) ? pages : pages + 1; // TODO do a better way to distinguish if number have the rest
    var pageNumbers = Enumerable.Range(1, pages);
    return Feed.CreateCircular(feedName, pageNumbers);
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

async Task<Response> GetResoursePage(HttpClient client, string resourse, int pageNumber, ILogger logger = null)
{
    var response = await client.GetAsync($"{baseUrl}/{resourse}?pageSize={pageSize}&pageNumber={pageNumber}");
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
