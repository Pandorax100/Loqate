using Loqate.Models.Find;
using Loqate.Models.Retrieve;

namespace Loqate.QueryBuilders;

public class QueryBuilderFactory
{
    public IQueryBuilder GetQueryBuilder(object parameters)
    {
        return parameters switch
        {
            FindRequestParameters requestParams => new FindRequestQueryBuilder(requestParams),
            RetrieveRequest requestParams => new RetrieveRequestQueryBuilder(requestParams),
            _ => throw new ArgumentOutOfRangeException(nameof(parameters)),
        };
    }
}
