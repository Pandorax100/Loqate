namespace Pandorax.Loqate.Models.Verify;

public class ServerOptions
{
    /// <summary>
    /// The default will Z00-00-00-000 (AVC) and Z (AQI), but computing the
    /// report values can be forced. Please note that if returned, these fields
    /// may not accurately reflect the changes made in the record during the CASS process.
    /// </summary>
    public bool? CassAvcEnable { get; set; }

    /// <summary>
    /// This specifies the Urbanization location on the address lines output (Puerto Rico only).
    /// The default will put the value after the address lines(s) with premise,
    /// thoroughfare, and sub-building.
    /// </summary>
    public bool? CassUrbFirst { get; set; }

    /// <summary>
    /// Populate “Finance” and “AutoZoneIndicator”. If these fields are desired, customers
    /// will experience a moderate performance degradation (up to 20%).
    /// </summary>
    public bool? CassZipFields { get; set; }

    /// <summary>
    /// If a Locality name is longer than 13 characters, this option can be
    /// used to return the official, short version. Both short and long
    /// versions are valid according to CASS.
    /// </summary>
    public bool? CassCityAbbreviation { get; set; }

    /// <summary>
    /// Used to specify the maximum number of results to return in the ProcessResults structure.
    /// </summary>
    public int? MaxResults { get; set; }

    /// <summary>
    /// Used to specify the minimum matchscore a record must reach in order to avoid reversion.
    /// </summary>
    public int? MinimumMatchScore { get; set; }

    /// <summary>
    /// Used to specify the minimum verification level a record must reach in order to avoid reversion.
    /// </summary>
    public int? MinimumVerificationLevel { get; set; }

    /// <summary>
    /// Used to specify the string which will separate the output address lines within the output Address field.
    /// </summary>
    public string? AddressLineSeparator { get; set; }

    /// <summary>
    /// Used to specify the minimum similarity score that is needed to make a match to a candidate result.
    /// </summary>
    public int MinimumSimilarity { get; set; }

    /// <summary>
    /// Used to specify the comma-delimited list of fields that should be suppressed from the Address field output.
    /// </summary>
    public string? SuppressAddressFields { get; set; }

    /// <summary>
    /// Used to specify the comma-delimited list of fields that should not be added to an output result if they do not appear in the input record.
    /// </summary>
    public string? SuppressAdditionalFields { get; set; }

    /// <summary>
    /// Used to specify the comma-delimited list of fields that should be suppressed from the output.
    /// </summary>
    public string? SuppressFields { get; set; }

    /// <summary>
    /// Specifies whether or not to use a word-based search algorithm similar to a web search engine approach.
    /// </summary>
    public bool? CombinedSearchMethods { get; set; }

    /// <summary>
    /// Used to specify the minimum GeoAccuracy level a geocode must reach in order to be returned as a result.
    /// </summary>
    public int? MinimumGeoAccuracyLevel { get; set; }

    /// <summary>
    /// Used to specify the maximum GeoDistance a geocode can reach and still be returned as a result.
    /// </summary>
    public int? MaximumGeoDistance { get; set; }

    /// <summary>
    /// Used to specify the language or character set (based on based on the ISO 15924 standard) in which the output should be encoded.
    /// </summary>
    public OutputScript? OutputScript { get; set; }

    /// <summary>
    /// Used to specify the letter case to use for output fields.
    /// </summary>
    public string? OutputCasing { get; set; }

    /// <summary>
    /// This option allows users to enable the Automatic Country Identification.
    /// </summary>
    public bool? EnhancedCountryTool { get; set; }

    /// <summary>
    /// Used to specify a comma-delimited list of countries where data should be processed using the relevant certified process. e.g. “USA,CAN,AUS” to give CASS, SERP, and AMAS certified output respectively.
    /// </summary>
    public string? CertifiedCountryList { get; set; }

    /// <summary>
    /// Used to specify the ISO 3166-1 alpha-3 code which should be used if no identifiable country can be found in an input record.
    /// </summary>
    public string? DefaultCountry { get; set; }

    /// <summary>
    /// Used to specify the comma delimited list of fields to be searched for country information. This should be a subset of the ParseFields entry.
    /// </summary>
    public string? CountryFields { get; set; }

    /// <summary>
    /// Used to specify the default field name weight, between 1 and 255. Default 10. A larger value will give more precedence to the supplied field name, a smaller value will give more precedence to the GKR matches. Individual field name weights can also be declared using the syntax ‘=|=’, etc. For instance ‘Organization=240|AdministrativeArea=100|50’ would mean a field name weight of 240 for the Organization field, 100 for the AdministrativeArea field, and a default of 50 for all remaining fields.
    /// </summary>
    public string? FieldNameWeight { get; set; }

    /// <summary>
    /// Used to specify the ISO 3166-1 alpha-3 code which should be used for all input records.
    /// </summary>
    public string? ForceCountry { get; set; }

    /// <summary>
    /// Used to specify the minimum matchscore a record must reach in the Match process to be taken into account as a candidate for matching.
    /// </summary>
    public int? MatchScoreAbsoluteThreshold { get; set; }

    /// <summary>
    /// This is a value that is used as a factor of the highest matching result. The resulting value is then used as a cut-off for considering candidates for the results. The higher the value of the factor, the higher the chance of getting a good verification result.
    /// </summary>
    public int? MatchScoreThresholdFactor { get; set; }

    /// <summary>
    /// Used to specify whether to output an extra field for the Address block fields with the suffix ‘Format’ showing how the hierarchical field positioning has occurred.
    /// </summary>
    public bool? OutputAddressFormat { get; set; }

    /// <summary>
    /// Used to specify the fields that should not be transliterated.
    /// </summary>
    public string? TransliterationIgnoreFields { get; set; }

    /// <summary>
    /// Specify ‘Yes’ to output extra debug information viewable using the getFieldInfo method.
    /// </summary>
    public bool? ToolInfo { get; set; }

    /// <summary>
    /// Specify ‘No’ to limit transliteration to complete field phrase matches.
    /// </summary>
    public bool? UseSymbolicTransliteration { get; set; }

    /// <summary>
    /// Used to specify the duplicate handling level, between 0 and 15. Default is 0. When option is set, duplicate components in the input address are removed if it meets a certain criteria.
    /// </summary>
    public string? DuplicateHandlingMask { get; set; }

    /// <summary>
    /// Used to specify whether to reverse the order of the input address lines when processing non-Latin data. Usually this is set on a per-country basis automatically, but can be overridden by setting the server option as appropriate. When set to False, any input Address lines are concatenated for parsing in normal order (e.g. Address1 + Address2 + Address3), when set to True any input Address lines are concatenated for parsing in reverse order (e.g. Address3 + Address2 + Address1).
    /// </summary>
    public string? NativeAddressLineReverse { get; set; }

    /// <summary>
    /// Specifies whether or not to use the ‘simple parse’ algorithm. This option looks for something like premise + street in the address field, but is not particularly tolerant of invalid input data.
    /// </summary>
    public bool? SimpleParse { get; set; }

    /// <summary>
    /// This option will return only verified fields, meaning that it will remove anything that isn’t verified from any field. SuppressUnmatched option will only suppress the unverified components in the Address field. Default No, meaning all fields will be returned. This can be specified on a per-country basis, with the added ability to specify fields to ignore during the check, using the following syntax ReturnVerifiedFieldsOnly=[:;;…;][,:;…;,…,]. e.g. ReturnVerifiedFieldsOnly=BE:SubBuilding;Premise,DE:SubBuilding;Premise,AT:SubBuilding;Premise or ReturnVerifiedFieldsOnly=US,CA,GB. The former will return verified fields only in Belgium, Germany, and Austria, but will retain non-verified data in the Premise and SubBuilding fields, the latter will return verified fields only in USA, Canada, UK.
    /// </summary>
    public string? ReturnVerifiedFieldsOnly { get; set; }

    /// <summary>
    /// This option produces a status code for every returned field.Default is 'false'; to see this value, set the option to 'true'. Examples include Verified, Identified, or Added.Statuses are defined here.
    /// </summary>
    public bool? FieldStatus { get; set; }

    /// <summary>
    /// ​Allow unmatched input data within the address lines to be ignored during a Search process, meaning that a search can proceed matching only partial input data.We don’t recommend you use this server option on a Verify process, as it may reduce the accuracy of otherwise valid results.
    /// </summary>
    public bool? IgnoreUnmatched { get; set; }

    /// <summary>
    /// Used to specify the minimum postcode status a record must reach in order to avoid reversion.
    /// </summary>
    public string? MinimumPostcode { get; set; }

    /// <summary>
    /// If this option is set to TRUE or ON, unverified fields will not be output in Address fields(Address, Address1, Address2, etc.).​
    /// </summary>
    public bool? SuppressUnmatched { get; set; }

    /// <summary>
    /// Used to specify the order in which the Search output results should be sorted.To sort in alphabetical order use ‘Alphabetical’, or alternatively specify ‘AVC’ to sort from the highest verification level to the lowest verification level. The option can also be set to ‘Similarity’ giving an indication of the percentage of the input characters that have been matched in the output.​
    /// </summary>
    public string? OutputSortType { get; set; }

    /// <summary>
    /// Used to specify how to expand ranges such as premise numbers and sub building numbers.Valid values are ‘Match’ (returning only the value matching the input query), ‘Range’ (returning a human-readable range, e.g. ‘1-9 Odd’), or ‘Full’ (expanding out the range into its constituent numbers, e.g. ‘1’, ‘2’, ‘3’, ‘4’, ‘5’).
    /// </summary>
    public string? RangeDecompose { get; set; }

    /// <summary>
    /// ​When option is set to “Yes”, the engine will pick out the first valid alias it finds within the reference data.
    /// </summary>
    public string? PreferPrimaryValidAlias { get; set; }

    /// <summary>
    /// Used to specify the number of MRU reference datasets to cache.
    /// </summary>
    public string? ReferenceDatasetCacheSize { get; set; }

}
