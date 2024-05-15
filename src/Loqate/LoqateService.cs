using System.Net.Http.Json;
using Loqate.Endpoints;
using Loqate.Models.Find;
using Loqate.Models.Retrieve;
using Loqate.QueryBuilders;

namespace Loqate;

public class LoqateService : ILoqateService
{
    private readonly HttpClient _httpClient;
    private readonly QueryBuilderFactory _queryBuilderFactory;

    public LoqateService(HttpClient httpClient, QueryBuilderFactory queryBuilderFactory)
    {
        _httpClient = httpClient;
        _queryBuilderFactory = queryBuilderFactory;
    }

    /// <inheritdoc />
    public async Task<FindResponse?> FindAddressesAsync(FindRequestParameters parameters)
    {
        IQueryBuilder queryBuilder = _queryBuilderFactory.GetQueryBuilder(parameters);

        string url = queryBuilder.AppendQueryString(EndpointConstants.FindEndpoint);

        FindResponse? response = await _httpClient.GetFromJsonAsync<FindResponse>(url);

        return response;
    }

    /// <inheritdoc />
    public async Task<RetrieveResponse?> RetrieveAddressAsync(RetrieveRequest parameters)
    {
        IQueryBuilder queryBuilder = _queryBuilderFactory.GetQueryBuilder(parameters);

        string url = queryBuilder.AppendQueryString(EndpointConstants.FindEndpoint);

        RetrieveResponse? response = await _httpClient.GetFromJsonAsync<RetrieveResponse>(url);

        return response;
    }
}
