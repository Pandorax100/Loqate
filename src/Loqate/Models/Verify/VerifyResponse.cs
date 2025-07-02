using Pandorax.Loqate.Models.Common;

namespace Pandorax.Loqate.Models.Verify;

public class VerifyResponse
{
    public required Address Input { get; set; }

    public List<VerifyMatch> Matches { get; set; } = [];

    public string? Version { get; set; }
}
