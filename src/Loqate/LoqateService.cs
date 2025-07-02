using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using Pandorax.Loqate.Endpoints;
using Pandorax.Loqate.Models.Find;
using Pandorax.Loqate.Models.Retrieve;
using Pandorax.Loqate.Models.Verify;
using Pandorax.Loqate.Options;
using Pandorax.Loqate.QueryBuilders;

namespace Pandorax.Loqate;

public class LoqateService : ILoqateService
{
    private readonly HttpClient _httpClient;
    private readonly QueryBuilderFactory _queryBuilderFactory;
    private readonly LoqateOptions _options;

    public LoqateService(
        HttpClient httpClient,
        QueryBuilderFactory queryBuilderFactory,
        IOptions<LoqateOptions> options)
    {
        _httpClient = httpClient;
        _queryBuilderFactory = queryBuilderFactory;
        _options = options.Value;
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

        string url = queryBuilder.AppendQueryString(EndpointConstants.RetrieveEndpoint);

        RetrieveResponse? response = await _httpClient.GetFromJsonAsync<RetrieveResponse>(url);

        return response;
    }

    /// <inheritdoc />
    public async Task<List<VerifyResponse>> VerifyBatchAsync(VerifyRequest request)
    {
        VerifyRequestInternal requestBody = new(request, _options.Key);

        using HttpResponseMessage response = await _httpClient.PostAsJsonAsync(
            EndpointConstants.AddressVerify,
            requestBody,
            LoqateJsonSerializerOptions.JsonSerializerOptions);

        List<VerifyResponse>? responseContent = await response.Content.ReadFromJsonAsync<List<VerifyResponse>>();

        return responseContent ?? [];
    }
}
