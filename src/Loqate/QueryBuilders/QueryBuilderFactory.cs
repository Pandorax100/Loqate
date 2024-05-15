using Pandorax.Loqate.Models.Find;
using Pandorax.Loqate.Models.Retrieve;

namespace Pandorax.Loqate.QueryBuilders;

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
