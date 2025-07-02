using Pandorax.Loqate.Models.Find;
using Pandorax.Loqate.Models.Retrieve;
using Pandorax.Loqate.Models.Verify;

namespace Pandorax.Loqate;

public interface ILoqateService
{
    /// <summary>
    /// Uses a text search to find addresses and places. Note this does not return formatted
    /// addresses, and repeated calls to this service may be required to drill-down through
    /// results until an address ID is returned. The address ID should then be passed into the
    /// Retrieve service to obtain a fully formatted address.
    /// </summary>
    /// <remarks>
    /// This method does not consume credit.
    /// </remarks>
    /// <param name="parameters">The parameters for the query.</param>
    Task<FindResponse?> FindAddressesAsync(FindRequestParameters parameters);

    /// <summary>
    /// Returns the full address details based on the Id.
    /// </summary>
    /// <remarks>
    /// This method consumes credit.
    /// </remarks>
    /// <param name="parameters">The parameters for the query.</param>
    Task<RetrieveResponse?> RetrieveAddressAsync(RetrieveRequest parameters);

    /// <summary>
    /// <para>Cleanses a batch of international addresses (and can also be used for single addresses).</para>
    /// <para>
    /// To enable the best customer experience, the recommendation is to send batches of less than 100
    /// records which are homogenous in terms of the location. Grouping the requests into countries
    /// enables the Verify engine to manage its resources more effectively.
    /// </para>
    /// </summary>
    /// <param name="request">The addresses to cleanse.</param>
    Task<List<VerifyResponse>> VerifyBatchAsync(VerifyRequest request);
}
