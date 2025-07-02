namespace Pandorax.Loqate.Models.Verify;

public class VerifyRequestOptions
{
    /// <summary>
    /// Return Loqate engine version with request.
    /// </summary>
    public bool Version { get; set; }

    /// <summary>
    /// Use certified data set. AMAS (AU), CASS (US) or SERP (CA). The country of the input address will determine which certification product is used.
    /// </summary>
    public bool Certify { get; set; }

    /// <summary>
    /// Use enhanced datasets. Returns enhance fields if applicable.
    /// </summary>
    public bool Enhance { get; set; }

    /// <summary>
    /// Loqate Process to run.
    /// </summary>
    public Process Process { get; set; }
}
