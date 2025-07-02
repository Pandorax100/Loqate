using Pandorax.Loqate.Models.Common;

namespace Pandorax.Loqate.Models.Verify;

public class VerifyRequest
{
    /// <summary>
    /// An array of addresses that you want to verify. The country field must contain a valid ISO2 or ISO3 country code. It is recommended that
    /// you use the structured fields (i.e. building/thoroughfare etc) over the address line input fields if the data you are cleansing
    /// is already structured.
    /// </summary>
    public List<Address> Addresses { get; set; } = [];

    /// <summary>
    /// Whether you want geo-coordinates to be appended to your results (if available). There is an additional cost associated with enabling this option.
    /// </summary>
    public bool? GeoCode { get; set; }

    public ServerOptions? Options { get; set; }
}
