using Microsoft.AspNetCore.WebUtilities;
using Pandorax.Loqate.Models.Find;

namespace Pandorax.Loqate.QueryBuilders;

internal class FindRequestQueryBuilder(FindRequestParameters parameters) : IQueryBuilder
{
    private readonly FindRequestParameters _parameters = parameters;

    public string AppendQueryString(string uri)
    {
        Dictionary<string, string?> queryParams = new()
        {
            ["Text"] = _parameters.Text,
            ["IsMiddleware"] = _parameters.IsMiddleware?.ToString(),
            ["Container"] = _parameters.Container,
            ["Origin"] = _parameters.Origin,
            ["Countries"] = string.Join(",", _parameters.Countries),
            ["Limit"] = _parameters.Limit?.ToString(),
            ["Language"] = _parameters.Language,
            ["Bias"] = _parameters.Bias?.ToString(),
            ["Filters"] = _parameters.Filters,
            ["GeoFence"] = _parameters.GeoFence,
        };

        return QueryHelpers.AddQueryString(uri, queryParams);
    }
}
