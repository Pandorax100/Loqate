using Loqate.Models.Retrieve;
using Microsoft.AspNetCore.WebUtilities;

namespace Loqate.QueryBuilders;

internal class RetrieveRequestQueryBuilder(RetrieveRequest parameters) : IQueryBuilder
{
    private readonly RetrieveRequest _parameters = parameters;

    public string AppendQueryString(string uri)
    {
        Dictionary<string, string?> queryParams = new()
        {
            ["Id"] = _parameters.Id,
            ["Field1Format"] = _parameters.Field1Format,
            ["Field2Format"] = _parameters.Field2Format,
            ["Field3Format"] = _parameters.Field3Format,
            ["Field4Format"] = _parameters.Field4Format,
            ["Field5Format"] = _parameters.Field5Format,
            ["Field6Format"] = _parameters.Field6Format,
            ["Field7Format"] = _parameters.Field7Format,
            ["Field8Format"] = _parameters.Field8Format,
            ["Field9Format"] = _parameters.Field9Format,
            ["Field10Format"] = _parameters.Field10Format,
            ["Field11Format"] = _parameters.Field11Format,
            ["Field12Format"] = _parameters.Field12Format,
            ["Field13Format"] = _parameters.Field13Format,
            ["Field14Format"] = _parameters.Field14Format,
            ["Field15Format"] = _parameters.Field15Format,
            ["Field16Format"] = _parameters.Field16Format,
            ["Field17Format"] = _parameters.Field17Format,
            ["Field18Format"] = _parameters.Field18Format,
            ["Field19Format"] = _parameters.Field19Format,
            ["Field20Format"] = _parameters.Field20Format,
        };

        return QueryHelpers.AddQueryString(uri, queryParams);
    }
}
