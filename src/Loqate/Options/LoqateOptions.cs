namespace Pandorax.Loqate.Options;

public class LoqateOptions
{
    /// <summary>
    /// The key to use to authenticate to the service. This must be obtained from Loqate.
    /// </summary>
    public string Key { get; set; } = string.Empty;

    /// <summary>
    /// The base address for the uri. Defaults to <see cref="LoqateConstants.DefaultBaseUri"/>.
    /// </summary>
    public Uri BaseAddress { get; set; } = LoqateConstants.DefaultBaseUri;
}
