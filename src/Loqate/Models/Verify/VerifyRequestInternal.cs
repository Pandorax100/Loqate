using System.Diagnostics.CodeAnalysis;

namespace Pandorax.Loqate.Models.Verify;

/// <summary>
/// Used to include the API key in the request.
/// </summary>
internal class VerifyRequestInternal : VerifyRequest
{
    [SetsRequiredMembers]
    public VerifyRequestInternal(VerifyRequest verifyRequest, string apiKey)
    {
        Addresses = verifyRequest.Addresses;
        GeoCode = verifyRequest.GeoCode;
        Options = verifyRequest.Options;
        Key = apiKey;
    }

    public required string Key { get; set; }
}
