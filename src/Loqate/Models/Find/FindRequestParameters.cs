namespace Loqate.Models.Find;

/// <summary>
/// Represents the request parameters for the capture find API endpoint.
/// </summary>
public class FindRequestParameters(string text)
{
    /// <summary>
    /// The search text to find. Ideally a postcode or the start of the address.
    /// </summary>
    public string Text { get; set; } = text ?? throw new ArgumentNullException(nameof(text));

    /// <summary>
    /// Whether the API is being called from a middleware implementation (and therefore the calling IP address should not be used for biasing).
    /// </summary>
    public bool? IsMiddleware { get; set; }

    /// <summary>
    /// A container for the search. This should only be another Id previously returned from this service when the Type of the result was not 'Address'.
    /// </summary>
    public string? Container { get; set; }

    /// <summary>
    /// A starting location for the search. This can be the name or ISO 2 or 3 character code of a country, WGS84 coordinates (comma separated) or IP address to search from.
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// A list of ISO 2 or 3 character country codes to limit the search within.
    /// </summary>
    public List<string> Countries { get; set; } = [];

    /// <summary>
    /// The maximum number of results to return.
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// <para>The preferred language for results where the same address matches input in different languages.</para>
    /// <para>
    /// This parameter will also affect the label "Addresses" in the Description field of the Container results, eg.
    /// where Language=es, the value will be "direcciones". The value should be a 2 or 4 character
    /// language code e.g. (en, fr, en-gb, en-us).
    /// </para>
    /// </summary>
    public string? Language { get; set; }

    /// <summary>
    /// Enable/Disable biasing.
    /// </summary>
    /// <remarks>
    /// When Bias is set to <see langword="true" /> and when the Origin value provided is WGS84 coordinates or an IP address, this
    /// allows the user to find addresses that are near to them with less entry. When Bias is
    /// set to False, information provided in the Origin field will be used to prefer
    /// address matches from the country that Origin field identifies.
    /// Has no effect on Capture v3 functionality.
    /// </remarks>
    public bool? Bias { get; set; }

    /// <summary>
    /// <para>
    /// This setting allows filtering of addresses returned by the Find method in the latest Capture.
    /// </para>
    /// <para>
    /// You can include or exclude certain type of addresses or locations from the address matches presented back to end user. All Filters are currently operating on the
    /// basis of an exact match. Multiple Filters can be provided in the same request.
    /// </para>
    /// <para>
    /// &amp;Filters=&lt;Fieldname&gt;:&lt;Text&gt; - this is an IS filter and will limit matches to the subset where this field value is as specified.
    /// </para>
    /// <para>
    /// &amp;Filters=!&lt;Fieldname&gt;:&lt;Text&gt; - this is an ISN'T filter and will exclude any matches where this field value is as specified.
    /// </para>
    /// </summary>
    /// <example>
    /// <para>
    /// This will return matches that are in Nottingham, UK and exclude addresses with NG11 7EP postcode:
    /// </para>
    /// <para>
    /// &amp;Filters=Locality:Nottingham&amp;Filters=!Postcode:NG11 7EP.
    /// </para>
    /// </example>
    /// <remarks>
    /// To view available filters, visit the Loqate documentation: https://www.loqate.com/developers/api/Capture/Interactive/Find/1.1/.
    /// </remarks>
    public string? Filters { get; set; }

    /// <summary>
    /// This setting allows specifying coordinates for points in a geofence. Only the addresses within specified geofence will be returned.
    /// </summary>
    public string? GeoFence { get; set; }

}
