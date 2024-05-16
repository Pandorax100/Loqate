namespace Pandorax.Loqate.Models.Retrieve;

/// <summary>
/// Represents the request parameters for the address retrieve request.
/// </summary>
public class RetrieveRequest(string id)
{
    /// <summary>
    /// The Id from a Find method to retrieve the details for.
    /// </summary>
    public string Id { get; set; } = id;

    public string? Field1Format { get; set; }
    public string? Field2Format { get; set; }
    public string? Field3Format { get; set; }
    public string? Field4Format { get; set; }
    public string? Field5Format { get; set; }
    public string? Field6Format { get; set; }
    public string? Field7Format { get; set; }
    public string? Field8Format { get; set; }
    public string? Field9Format { get; set; }
    public string? Field10Format { get; set; }
    public string? Field11Format { get; set; }
    public string? Field12Format { get; set; }
    public string? Field13Format { get; set; }
    public string? Field14Format { get; set; }
    public string? Field15Format { get; set; }
    public string? Field16Format { get; set; }
    public string? Field17Format { get; set; }
    public string? Field18Format { get; set; }
    public string? Field19Format { get; set; }
    public string? Field20Format { get; set; }
}
