using NBomber.Configuration;
using NBomber.Contracts;
using NBomber.CSharp;
using Serilog;

const int pageSize = 100;
const string baseUrl = "https://localhost:44327/customer";

using var httpClient = new HttpClient();

// TODO move to some common code
var orderPageNumbersFeed = await GetOrdersPageNumberFeed(httpClient);
var productPageNumbersFeed = await GetProductsPageNumberFeed(httpClient);

var clientFactory = ClientFactory.Create(
    name: "http_factory",
    clientCount: 30,
    initClient: (number, context) => Task.FromResult(new HttpClient()));

var getOrdersPageStep = Step.Create("getOrdersPage", clientFactory, orderPageNumbersFeed, (context) =>
{
    return GetResoursePage(context.Client, pageNumber: context.FeedItem, "orders");
});

var getProductsPageStep = Step.Create("getProductsPage", clientFactory, productPageNumbersFeed, (context) =>
{
    return GetResoursePage(context.Client, pageNumber: context.FeedItem, "products");
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



Task<IFeed<int>> GetOrdersPageNumberFeed(HttpClient client)
{
    return GetPageNumberFeed(client, "/orders/count", "ordersPageNumbers");
}

Task<IFeed<int>> GetProductsPageNumberFeed(HttpClient client)
{
    return GetPageNumberFeed(client, "/products/count", "productsPageNumbers");
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

async Task<Response> GetResoursePage(HttpClient client, int pageNumber, string resourse, ILogger logger = null)
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
