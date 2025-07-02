namespace Pandorax.Loqate.Models.Verify;

public class VerifyMatch
{
    /// <summary>
    /// This field is available when adding “SERP” to the Loqate engine. Sometimes a site
    /// specification and compartment is assigned for delivery to a rural address that does not
    /// have a civic address. Example value: SITE 6 COMP 10.
    /// </summary>
    public string? AdditionalContent { get; set; }

    public string? AdditionalContentStatus { get; set; }

    /// <summary>
    /// The full address, correctly formatted for mailing in the relevant country, including line
    /// breaks specified using the AddressLineSeparator option. Do not use ‘Address’ as input
    /// when running CASS. The preferred input for CASS is (Address1 + Locality +
    /// AdministrativeArea + PostalCode + Country). However, (Address1 + Address2 + Country) will
    /// also work.
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// The Address1-8 fields can be used to specify input address line data, and on output will
    /// contain the correctly formatted address split into individual address lines for mailing
    /// in the relevant country.
    /// </summary>
    public string? Address1 { get; set; }

    public string? Address1Status { get; set; }

    public string? Address2 { get; set; }

    public string? Address2Status { get; set; }

    public string? Address3 { get; set; }

    public string? Address3Status { get; set; }

    public string? Address4 { get; set; }

    public string? Address4Status { get; set; }

    public string? Address5 { get; set; }

    public string? Address5Status { get; set; }

    public string? Address6 { get; set; }

    public string? Address6Status { get; set; }

    public string? Address7 { get; set; }

    public string? Address7Status { get; set; }

    public string? Address8 { get; set; }

    public string? Address8Status { get; set; }

    /// <summary>
    /// If Server Option “OutputAddressFormat“ is “Yes“, then this field will contain the fields
    /// used to construct the “Address“ Field. For example,
    /// “Organization&lt;BR&gt;DeliveryAddress&lt;BR&gt;Locality AdministrativeArea PostalCode“. The default
    /// “&lt;BR&gt;“ line breaks can be changed with the AddressLineSeparator Server Option.
    /// </summary>
    public string? AddressFormat { get; set; }

    public string? AddressFormatStatus { get; set; }

    /// <summary>
    /// Every address in the Royal Mail Postal Address File (PAF) is assigned an 8-digit value
    /// that serves as a persistent reference to a building or delivery point, even when there
    /// are changes to a postcode.
    /// </summary>
    public string? AddressKey { get; set; }

    public string? AddressKeyStatus { get; set; }

    public string? AddressStatus { get; set; }

    /// <summary>
    /// The most common geographic data element within a country. For instance, USA State, and
    /// Canadian Province.
    /// </summary>
    public string? AdministrativeArea { get; set; }

    /// <summary>
    /// See
    /// [here](https://support.loqate.com/support/data-enhancement-administrativearea-iso-2-code/)
    /// for full details.
    /// </summary>
    public string? AdministrativeAreaIso2 { get; set; }

    public string? AdministrativeAreaIso2Status { get; set; }

    /// <summary>
    /// The name indicator within the AdministrativeArea field, should one exist. For example,
    /// Taipai where the AdministrativeArea is Taipai City.
    /// </summary>
    public string? AdministrativeAreaName { get; set; }

    public string? AdministrativeAreaNameStatus { get; set; }

    public string? AdministrativeAreaStatus { get; set; }

    /// <summary>
    /// The trailing AdministrativeArea type, should one exist. For example, City where the
    /// AdministrativeArea is Taipai City.
    /// </summary>
    public string? AdministrativeAreaTrailingType { get; set; }

    public string? AdministrativeAreaTrailingTypeStatus { get; set; }

    /// <summary>
    /// The AdministrativeArea type, should one exist. For example, City where the
    /// AdministrativeArea is Taipai City.
    /// </summary>
    public string? AdministrativeAreaType { get; set; }

    public string? AdministrativeAreaTypeStatus { get; set; }

    /// <summary>
    /// Alternative value for AdministrativeArea, or County, in the United Kingdom. Defined and
    /// supplied by Royal Mail. This is the Unitary Authority name (where one is present), and
    /// provided by the Office for National Statistics. This field can change more frequently due
    /// to administrative changes in the respective area. E.g. “Bristol, City Of”.
    /// </summary>
    public string? AdministrativeCounty { get; set; }

    public string? AdministrativeCountyStatus { get; set; }

    /// <summary>
    /// Address Quality Index. Offers a view of overall address quality (see the [AQI
    /// page](https://support.loqate.com/documentation/reportcodes/address-quality-index/) for
    /// more information), but is not used as a metric for deciding whether to accept an address
    /// which has been processed via Verify. **Please use the AVC to verify addresses**.
    /// </summary>
    public string? Aqi { get; set; }

    public string? AqiStatus { get; set; }

    /// <summary>
    /// Automated Zone Indicator: specifies if carrier sort rates apply, and if a merge is
    /// allowed. This field will be blank due to performance reasons unless the server option
    /// CassZipFields is set to “Yes”. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? AutoZoneIndicator { get; set; }

    public string? AutoZoneIndicatorStatus { get; set; }

    /// <summary>
    /// Address Verification Code. A response code which includes information associated with the
    /// parsing and matching of the address record. Use this to identify the level to which an
    /// address has been verified. See the [AVC
    /// page](https://support.loqate.com/documentation/reportcodes/address-verification-code/)
    /// for more information.
    /// </summary>
    public string? Avc { get; set; }

    public string? AvcStatus { get; set; }

    /// <summary>
    /// Standard barcode based on the DPID.
    /// </summary>
    public string? Barcode { get; set; }

    public string? BarcodeStatus { get; set; }

    /// <summary>
    /// Defines the census data that represent the smallest geographic unit used by the US Census
    /// Bureau. See [here](https://support.loqate.com/us-census-data-enhancement/) for full
    /// details.
    /// </summary>
    public string? BlockCode { get; set; }

    public string? BlockCodeStatus { get; set; }

    /// <summary>
    /// Defines the census data that represent the group of Blocks. See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for full details.
    /// </summary>
    public string? BlockGroupCode { get; set; }

    public string? BlockGroupCodeStatus { get; set; }

    /// <summary>
    /// The utility unit number consists of a letter followed by four numbers (Norway/NO/NOR
    /// only). Examples include: H0001, L0002, U0004, K0032.
    /// </summary>
    public string? Bolignummer { get; set; }

    public string? BolignummerStatus { get; set; }

    /// <summary>
    /// Box lobby name or New Zealand Post shop name (New Zealand/NZ/NZL only). Examples include:
    /// MAUNGATAPERE POSTCENTRE, NEWMARKET POSTSHOP, MOUNT COOK.
    /// </summary>
    public string? BoxBagLobbyName { get; set; }

    public string? BoxBagLobbyNameStatus { get; set; }

    /// <summary>
    /// Branch name of Department field (Canada/CA/CAN only). Examples include: Agence De Parcs
    /// Canada, Fisheries and Oceans, Ottawa District Office.
    /// </summary>
    public string? BranchName { get; set; }

    public string? BranchNameStatus { get; set; }

    /// <summary>
    /// The descriptive name identifying an individual location, should one exist.
    /// </summary>
    public string? Building { get; set; }

    /// <summary>
    /// The leading building type indicator within the Building field, should one exist. For
    /// instance, if Building contains “BLOC C” BuildingLeadingType contains “BLOC” if a
    /// sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? BuildingLeadingType { get; set; }

    public string? BuildingLeadingTypeStatus { get; set; }

    /// <summary>
    /// The name indicator within the Building field, should one exist. For instance, if Building
    /// contains “WESTMINSTER HOUSE” BuildingName contains “WESTMINSTER” if a sufficient level of
    /// parsing detail exists for the particular country.
    /// </summary>
    public string? BuildingName { get; set; }

    public string? BuildingNameStatus { get; set; }

    public string? BuildingStatus { get; set; }

    /// <summary>
    /// The trailing building type indicator within the Building field, should one exist. For
    /// instance, if Building contains “WESTMINSTER HOUSE” BuildingTrailingType contains “HOUSE”
    /// if a sufficient level of parsing detail exists within a particular country.
    /// </summary>
    public string? BuildingTrailingType { get; set; }

    public string? BuildingTrailingTypeStatus { get; set; }

    /// <summary>
    /// The Building indicator within the Building field, should one exist. Examples include
    /// Place, 城.
    /// </summary>
    public string? BuildingType { get; set; }

    public string? BuildingTypeStatus { get; set; }

    /// <summary>
    /// The carrier route code assigned to a mail delivery or collection route within a 5-digit
    /// ZIP Code. This is also referred to as CRID. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? CarrierRoute { get; set; }

    public string? CarrierRouteStatus { get; set; }

    /// <summary>
    /// Defines that the Census data is referencing the Core-Based Statistical Area (CBSA), in
    /// typically 5-digits value. See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for full details.
    /// </summary>
    public string? CbsaCode { get; set; }

    public string? CbsaCodeStatus { get; set; }

    /// <summary>
    /// Defines that the Census data is referencing the Core Based Statistical Area (CBSA). See
    /// [here](https://support.loqate.com/support/data-enhancement-us-census-data-fields/) for
    /// full details.
    /// </summary>
    public string? CbsaMetropolitanStatisticalArea { get; set; }

    public string? CbsaMetropolitanStatisticalAreaStatus { get; set; }

    /// <summary>
    /// CBSA Micropolitan Statistical Area. See
    /// [here](https://support.loqate.com/support/data-enhancement-us-census-data-fields/) for
    /// full details.
    /// </summary>
    public string? CbsaMicropolitanStatisticalArea { get; set; }

    public string? CbsaMicropolitanStatisticalAreaStatus { get; set; }

    /// <summary>
    /// Refers to the official name given to the CBSAs which complements the CBSACode field value
    /// as defined above. For definition of CBSA, please refer to the CBSACode field definition
    /// above.
    /// </summary>
    public string? CbsaName { get; set; }

    public string? CbsaNameStatus { get; set; }

    /// <summary>
    /// Census Class Code defines the census classification of a place. Census Class Code
    /// corresponding to the FIPS 55-3 standard. Census Class Codes are alphanumeric and can be
    /// referred at https://www.census.gov/library/reference/code-lists/class-codes.html. Census
    /// Class Codes are published only for level 3 and 4 Administrative Areas and Zones. See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for more details.
    /// </summary>
    public string? CensusClassCode { get; set; }

    public string? CensusClassCodeStatus { get; set; }

    /// <summary>
    /// Census Code defines that the Census data is referencing the Census Codes, previously
    /// known as the Federal Information Processing Standard (FIPS) code. Unlike its previous
    /// FIPS code value, Census Codes are currently used as the government code to represent
    /// Admin Places in the U.S. Census Codes are published for Administrative Areas (Admin Level
    /// 1-4 in the U.S.) and all Zones with official government codes.
    /// </summary>
    public string? CensusCode { get; set; }

    public string? CensusCodeStatus { get; set; }

    /// <summary>
    /// The address level for which the census data was returned. In Census Plus, this field will
    /// show the value “Premise”, the most accurate address level in Census Plus data, when there
    /// is Premise level match found. Otherwise, the value field would not be visible.
    /// </summary>
    public string? CensusIndicator { get; set; }

    public string? CensusIndicatorStatus { get; set; }

    /// <summary>
    /// Delivery Point Bar Code check digit. This is the last character of the
    /// DeliveryPointBarCode.
    /// </summary>
    public string? CheckDigit { get; set; }

    public string? CheckDigitStatus { get; set; }

    /// <summary>
    /// Indicates whether the address is associated with a Commercial Mail Receiving
    /// Agency(CMRA). See [here](https://support.loqate.com/cass2-output-field-descriptions/) for
    /// more details.
    /// </summary>
    public string? CmraIndicator { get; set; }

    public string? CmraIndicatorStatus { get; set; }

    /// <summary>
    /// The congressional district to which the address belongs.
    /// </summary>
    public string? CongressionalDistrict { get; set; }

    public string? CongressionalDistrictStatus { get; set; }

    /// <summary>
    /// Contact name information.
    /// </summary>
    public string? Contact { get; set; }

    public string? ContactStatus { get; set; }

    /// <summary>
    /// This field is used to supply the country name or code (ISO 3166 2-character country code
    /// and ISO 3166 3-character country code).
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// The ISO 3166 official country name.
    /// </summary>
    public string? CountryName { get; set; }

    public string? CountryNameStatus { get; set; }

    public string? CountryStatus { get; set; }

    /// <summary>
    /// The primary legal divisions of most states are termed counties. See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for full details.
    /// </summary>
    public string? CountyCode { get; set; }

    public string? CountyCodeStatus { get; set; }

    /// <summary>
    /// A value of “Y” indicates that the record matched to a high-rise default, rural route
    /// default, or street default record in the ZIP+4 file. Blank = not a default.
    /// </summary>
    public string? DefaultFlag { get; set; }

    public string? DefaultFlagStatus { get; set; }

    /// <summary>
    /// The full address minus the Organization, Locality, AdministrativeArea hierarchy and
    /// PostalCode hierarchy fields, correctly formatted for mailing in the relevant country,
    /// including line breaks specified using the AddressLineSeparator option.
    /// </summary>
    public string? DeliveryAddress { get; set; }

    /// <summary>
    /// The DeliveryAddress1-8 fields contain the individual lines contained within the
    /// DeliveryAddress field.
    /// </summary>
    public string? DeliveryAddress1 { get; set; }

    public string? DeliveryAddress1Status { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public string? DeliveryAddress2Status { get; set; }

    public string? DeliveryAddress3 { get; set; }

    public string? DeliveryAddress3Status { get; set; }

    public string? DeliveryAddress4 { get; set; }

    public string? DeliveryAddress4Status { get; set; }

    public string? DeliveryAddress5 { get; set; }

    public string? DeliveryAddress5Status { get; set; }

    public string? DeliveryAddress6 { get; set; }

    public string? DeliveryAddress6Status { get; set; }

    public string? DeliveryAddress7 { get; set; }

    public string? DeliveryAddress7Status { get; set; }

    public string? DeliveryAddress8 { get; set; }

    public string? DeliveryAddress8Status { get; set; }

    /// <summary>
    /// If Server Option “OutputAddressFormat“ is “Yes“, then this field will contain the fields
    /// used to construct the “DeliveryAddress“ Field. For example,
    /// “Organization&lt;BR&gt;DeliveryAddress&lt;BR&gt;Locality AdministrativeArea PostalCode“. The default
    /// “&lt;BR&gt;“ line breaks can be changed with the AddressLineSeparator Server Option.
    /// </summary>
    public string? DeliveryAddressFormat { get; set; }

    public string? DeliveryAddressFormatStatus { get; set; }

    public string? DeliveryAddressStatus { get; set; }

    /// <summary>
    /// This field is available when adding “SERP” to the Loqate engine. It contains the Station
    /// Information to direct mail to the proper postal installation for non-civic addresses.
    /// Example value: STN A.
    /// </summary>
    public string? DeliveryInstallation { get; set; }

    /// <summary>
    /// The name of a village, town, municipality, city, or metropolitan area that forms part of
    /// a Delivery Installation Name (Canada/CA/CAN only). Examples include: Ladysmith, Roxton
    /// Pond.
    /// </summary>
    public string? DeliveryInstallationAreaName { get; set; }

    public string? DeliveryInstallationAreaNameStatus { get; set; }

    /// <summary>
    /// When more than one delivery installation serves an area described by the Delivery
    /// Installation Area Name, the qualifier name uniquely identifies the delivery installation
    /// (Canada/CA/CAN only). Examples include: Cap-A-L’aigle, B, St Michel, 32, Bank Hunt Club.
    /// </summary>
    public string? DeliveryInstallationQualifierName { get; set; }

    public string? DeliveryInstallationQualifierNameStatus { get; set; }

    public string? DeliveryInstallationStatus { get; set; }

    /// <summary>
    /// An abbreviation that represents the type of installation (Canada/CA/CAN only). Examples
    /// include: STN – Postal Station, PO – Post Office, BDP – Bureau De Poste.
    /// </summary>
    public string? DeliveryInstallationType { get; set; }

    public string? DeliveryInstallationTypeStatus { get; set; }

    /// <summary>
    /// A 3-digit code which consists of the 2-digit delivery point code and 1-digit check digit.
    /// This is used to create the 12-digit POSTNET barcode which consists of the 5-digit ZIP
    /// Code, 4-digit ZIP+4 addon code, and this 3-digit code.
    /// </summary>
    public string? DeliveryPointBarCode { get; set; }

    public string? DeliveryPointBarCodeStatus { get; set; }

    /// <summary>
    /// Organizational department information.
    /// </summary>
    public string? Department { get; set; }

    public string? DepartmentStatus { get; set; }

    /// <summary>
    /// A smaller population center data element, dependent on the contents of the Locality
    /// field. For instance, Turkish Neighborhood.
    /// </summary>
    public string? DependentLocality { get; set; }

    /// <summary>
    /// The leading dependent locality type indicator, should one exist. For example, “Rancheria
    /// San Jose Cacahuatepec” where the DependentLocality is Ciudad Renacimiento.
    /// </summary>
    public string? DependentLocalityLeadingType { get; set; }

    public string? DependentLocalityLeadingTypeStatus { get; set; }

    /// <summary>
    /// The name indicator within the DependentLocality field, should one exist. For instance, if
    /// DependentLocality contains “Dong Cheng Qu” DependentLocalityName contains “Dong Cheng” if
    /// a sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? DependentLocalityName { get; set; }

    public string? DependentLocalityNameStatus { get; set; }

    public string? DependentLocalityStatus { get; set; }

    /// <summary>
    /// The DependentLocality indicator within the DependentLocality field, should one exist. For
    /// instance, if DependentLocality contains “Dong Cheng Qu” DependentLocalityType contains
    /// “Qu” if a sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? DependentLocalityType { get; set; }

    public string? DependentLocalityTypeStatus { get; set; }

    /// <summary>
    /// The dependent street or block data element within a country. For instance, UK Dependent
    /// Street.
    /// </summary>
    public string? DependentThoroughfare { get; set; }

    /// <summary>
    /// The leading thoroughfare type indicator within the DependentThoroughfare field, should
    /// one exist. For instance, if DependentThoroughfare contains “RUE DE LA GARE”
    /// DependentThoroughfareLeadingType contains “RUE” if a sufficient level of parsing detail
    /// exists for the particular country.
    /// </summary>
    public string? DependentThoroughfareLeadingType { get; set; }

    public string? DependentThoroughfareLeadingTypeStatus { get; set; }

    /// <summary>
    /// The name indicator within the DependentThoroughfare field, should one exist. For
    /// instance, if DependentThoroughfare contains “N MAIN ST” DependentThoroughfareName
    /// contains “MAIN” if a sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? DependentThoroughfareName { get; set; }

    public string? DependentThoroughfareNameStatus { get; set; }

    /// <summary>
    /// The postfix directional contained within the DependentThoroughfare field, should one
    /// exist. For instance, if DependentThoroughfare contains “MAIN ST N”
    /// DependentThoroughfarePostDirection contains “N” if a sufficient level of parsing detail
    /// exists for the particular country.
    /// </summary>
    public string? DependentThoroughfarePostDirection { get; set; }

    public string? DependentThoroughfarePostDirectionStatus { get; set; }

    /// <summary>
    /// The prefix directional contained within the DependentThoroughfare field, should one
    /// exist. For instance, if DependentThoroughfare contains “N MAIN ST”
    /// DependentThoroughfarePreDirection contains “N” if a sufficient level of parsing detail
    /// exists for the particular country.
    /// </summary>
    public string? DependentThoroughfarePreDirection { get; set; }

    public string? DependentThoroughfarePreDirectionStatus { get; set; }

    public string? DependentThoroughfareStatus { get; set; }

    /// <summary>
    /// The trailing thoroughfare type indicator within the DependentThoroughfare field, should
    /// one exist. For instance, if DependentThoroughfare contains “N MAIN ST”
    /// DependentThoroughfareTrailingType contains “ST” if a sufficient level of parsing detail
    /// exists for the particular country.
    /// </summary>
    public string? DependentThoroughfareTrailingType { get; set; }

    public string? DependentThoroughfareTrailingTypeStatus { get; set; }

    /// <summary>
    /// DPV Door Not Accessible. Addresses where the USPS cannot knock on a door to deliver a
    /// package that will not fit in the mailbox. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? Dna { get; set; }

    public string? DnaStatus { get; set; }

    /// <summary>
    /// The smallest population center data element, dependent on both the contents of the
    /// Locality and DependentLocality fields. For instance, UK Village.
    /// </summary>
    public string? DoubleDependentLocality { get; set; }

    /// <summary>
    /// The name indicator within the DoubleDependentLocality field, should one exist. For
    /// instance, if DoubleDependentLocality contains “Xin Zhuang Zhen”
    /// DoubleDependentLocalityName contains “Xin Zhuang” if a sufficient level of parsing detail
    /// exists for the particular country.
    /// </summary>
    public string? DoubleDependentLocalityName { get; set; }

    public string? DoubleDependentLocalityNameStatus { get; set; }

    public string? DoubleDependentLocalityStatus { get; set; }

    /// <summary>
    /// The DoubleDependentLocality indicator within the DoubleDependentLocality field, should
    /// one exist. For instance, if DoubleDependentLocality contains “Xin Zhuang Zhen”
    /// DoubleDependentLocalityType contains “Zhen” if a sufficient level of parsing detail
    /// exists for the particular country.
    /// </summary>
    public string? DoubleDependentLocalityType { get; set; }

    public string? DoubleDependentLocalityTypeStatus { get; set; }

    /// <summary>
    /// A unique 8-digit number which is assigned for every new address to the source address
    /// database.
    /// </summary>
    public string? Dpid { get; set; }

    public string? DpidStatus { get; set; }

    /// <summary>
    /// The Delivery Point Suffix (DPS) is used with a postcode to generate a machine-readable
    /// barcode (RM4SCC), which then serves as a unique reference to an active property or
    /// delivery point. It is made up of one number (1-9) and one character (A-T), and is
    /// assigned by Royal Mail. It is possible that an address is not assigned a DPS value, in
    /// which case a default value of 9U or 9Z is used. 1A is also reserved for postcodes that
    /// have PostCodeType = L (Large User). See
    /// [here](https://support.loqate.com/gb-enhancement-data-fields/) for more details.
    /// </summary>
    public string? Dps { get; set; }

    public string? DpsStatus { get; set; }

    /// <summary>
    /// Delivery Point Validation (DPV) Confirmed Indicator: specifies the deliverability of the
    /// address. See [here](https://support.loqate.com/cass2-output-field-descriptions/) for more
    /// details.
    /// </summary>
    public string? DpvConfirmedIndicator { get; set; }

    public string? DpvConfirmedIndicatorStatus { get; set; }

    /// <summary>
    /// Delivery Point Validation footnotes. There can be one or more two-character footnotes.
    /// This field is used together with the DPVConfirmedIndicator field to understand the input
    /// address’ validity and deliverability. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? DpvFootnotes { get; set; }

    public string? DpvFootnotesStatus { get; set; }

    /// <summary>
    /// This field will always be empty.
    /// </summary>
    public string? DpvlacsIndicator { get; set; }

    public string? DpvlacsIndicatorStatus { get; set; }

    /// <summary>
    /// A flag that indicates mail is delivered to a single receptible at a site. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? DropSiteIndicator { get; set; }

    public string? DropSiteIndicatorStatus { get; set; }

    /// <summary>
    /// eLOT directional indicator. See the eLOTNumber field for additional information. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? ELotCode { get; set; }

    public string? ELotCodeStatus { get; set; }

    /// <summary>
    /// 4-digit sequence number for eLOT (Enhanced Line of Travel): gives mailers the ability to
    /// sort their mailings in approximate carrier-casing sequence. eLOT sorting allows for
    /// carrier route presort discounts. Blank = address not submitted for eLOT. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? ELotNumber { get; set; }

    public string? ELotNumberStatus { get; set; }

    /// <summary>
    /// Enhanced DPV Return Code. This is populated when there is more than one valid
    /// DPVConfirmedIndicator. When present, this should take precedence over
    /// DPVConfirmedIndicator. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? EnhancedReturnCode { get; set; }

    public string? EnhancedReturnCodeStatus { get; set; }

    /// <summary>
    /// A value of “Y” indicates that the address matched a record in the EWS (Early Warning
    /// System) file, thus resulting in a ZIP+4 no match. Blank = address was not flagged by EWS.
    /// </summary>
    public string? EwsFlag { get; set; }

    public string? EwsFlagStatus { get; set; }

    /// <summary>
    /// The False Positive table flags the False Positive addresses.  This is a flag to determine
    /// whether a mailing list is being generated or created during validation.  Creating a
    /// mailing list through DPV certification is not allowed by the USPS. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? FalsePositiveIndicator { get; set; }

    public string? FalsePositiveIndicatorStatus { get; set; }

    /// <summary>
    /// A code assigned to Postal Service™ facilities (primarily Post Offices) to collect cost
    /// and statistical data and compile revenue and expense data. An example output for 805
    /// Veterans Blvd, Redwood City, CA 94063 is 056378. Note that the reference for this
    /// information can be found
    /// [here](https://postalpro.usps.com/address-quality/AIS_Products_Technical_Guide). This
    /// field will be blank due to performance reasons unless the server option CassZipFields is
    /// set to “Yes”.
    /// </summary>
    public string? Finance { get; set; }

    public string? FinanceStatus { get; set; }

    /// <summary>
    /// The 5 digit FIPS (Federal Information Processing Standard) code which uniquely identifies
    /// counties. The first two will be the state code and the last three are the county. For
    /// example, San Francisco, CA is 06075.
    /// </summary>
    public string? FipsCountyCode { get; set; }

    public string? FipsCountyCodeStatus { get; set; }

    /// <summary>
    /// Floor or level number (including alpha characters).
    /// </summary>
    public string? FloorNumber { get; set; }

    public string? FloorNumberStatus { get; set; }

    /// <summary>
    /// Type of floor or level.
    /// </summary>
    public string? FloorType { get; set; }

    public string? FloorTypeStatus { get; set; }

    /// <summary>
    /// Default value for AdministrativeArea, or County, in the United Kingdom. Defined and
    /// supplied by Royal Mail. These values were used prior to the postcode system introduced in
    /// the 1970s to differentiate Locality names that were the same, or similar (e.g. 'Avon').
    /// This field is assigned as the AdministrativeArea default as it remains static and
    /// provides a consistent geographic boundary.
    /// </summary>
    public string? FormerPostalCounty { get; set; }

    public string? FormerPostalCountyStatus { get; set; }

    /// <summary>
    /// Function or job title information.
    /// </summary>
    public string? Function { get; set; }

    public string? FunctionStatus { get; set; }

    /// <summary>
    /// This field is available when adding “SERP” to the Loqate engine. It identifies a General
    /// Delivery type address – Example value: GD.
    /// </summary>
    public string? GeneralDelivery { get; set; }

    public string? GeneralDeliveryStatus { get; set; }

    /// <summary>
    /// The [GeoAccuracy](https://support.loqate.com/geoaccuracy) code.
    /// </summary>
    public string? GeoAccuracy { get; set; }

    public string? GeoAccuracyStatus { get; set; }

    /// <summary>
    /// The radius of accuracy in meters, giving an indication of the likely maximum distance
    /// between the given geocode and the physical location. Please note that this field is
    /// derived from and therefore dependent on the accuracy and coverage of the underlying
    /// reference data.
    /// </summary>
    public string? GeoDistance { get; set; }

    public string? GeoDistanceStatus { get; set; }

    /// <summary>
    /// GNIS Feature ID defines the census data that is referencing the Geographic Names
    /// Information System (GNIS) Feature ID. See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for full details.
    /// </summary>
    public string? GnisFeatureId { get; set; }

    public string? GnisFeatureIdStatus { get; set; }

    /// <summary>
    /// [https://support.loqate.com/documentation/fielddescrip/objfeilds/](https://support.loqate.com/documentation/fielddescrip/objfeilds/).
    /// </summary>
    public string? HyphenClass { get; set; }

    public string? HyphenClassStatus { get; set; }

    /// <summary>
    /// Optional. This field will be passed through to the output unchanged.
    /// </summary>
    public string? Id { get; set; }

    public string? IdStatus { get; set; }

    /// <summary>
    /// The ISO 3166 2-character country code.
    /// </summary>
    public string? Iso31662 { get; set; }

    public string? Iso31662Status { get; set; }

    /// <summary>
    /// The ISO 3166 3-character country code.
    /// </summary>
    public string? Iso31663 { get; set; }

    public string? Iso31663Status { get; set; }

    /// <summary>
    /// The ISO 3166 3-digit numeric country code.
    /// </summary>
    public string? Iso3166N { get; set; }

    public string? Iso3166NStatus { get; set; }

    /// <summary>
    /// Code returned by LACSLink®  after querying the LACSLink® database. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? LacsLinkCode { get; set; }

    public string? LacsLinkCodeStatus { get; set; }

    /// <summary>
    /// Indicator returned by LACSLink® after querying the LACSLink® database. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? LacsLinkIndicator { get; set; }

    public string? LacsLinkIndicatorStatus { get; set; }

    /// <summary>
    /// A value of “L” indicates that the input address matched an entry in the Locatable Address
    /// Conversion Service database and the input address has been converted from a rural-style
    /// address to a city-style address. Blank = no LACS Status returned.
    /// </summary>
    public string? LacsStatus { get; set; }

    public string? LacsStatusStatus { get; set; }

    /// <summary>
    /// The WGS 84 latitude in decimal degrees format.
    /// </summary>
    public string? Latitude { get; set; }

    /// <summary>
    /// Each of the following '-Status' fields is an indicator to show if a field is Verified or
    /// Identified.
    /// </summary>
    public string? LatitudeStatus { get; set; }

    /// <summary>
    /// The most common population center data element within a country. For instance, USA City,
    /// Canadian Municipality.
    /// </summary>
    public string? Locality { get; set; }

    /// <summary>
    /// Information that could be present along with the Locality. This information is not
    /// considered as part of the Postal authority data but is still necessary for parsing the
    /// address in order to obtain a complete delivery address. Available if a sufficient level
    /// of parsing detail exists within a particular country. Example: 12 rue de la Gare, 75019
    /// PARIS CEDEX, France. CEDEX will be considered as Locality Extra.
    /// </summary>
    public string? LocalityExtra { get; set; }

    public string? LocalityExtraStatus { get; set; }

    /// <summary>
    /// The name indicator within the Locality field, should one exist. For example: Jeju where
    /// the Locality is Jeju-Si.
    /// </summary>
    public string? LocalityName { get; set; }

    public string? LocalityNameStatus { get; set; }

    /// <summary>
    /// This field combines both the Locality and LocalityExtra components, to capture specific
    /// locality information that includes essential details for accurate address parsing and
    /// delivery. For example, in the address “12 rue de la Gare, 75019 PARIS CEDEX, France,” the
    /// term “Paris CEDEX” represents the LocalitySpecial. It encompasses both the primary
    /// locality (Paris) and the additional locality information (CEDEX) that is necessary for a
    /// complete and precise delivery address.
    /// </summary>
    public string? LocalitySpecial { get; set; }

    public string? LocalitySpecialStatus { get; set; }

    public string? LocalityStatus { get; set; }

    /// <summary>
    /// The type indicator for Locality, should one exist. For example: Dist. where the Locality
    /// is Da’an Dist.
    /// </summary>
    public string? LocalityTrailingType { get; set; }

    public string? LocalityTrailingTypeStatus { get; set; }

    /// <summary>
    /// The type indicator for Locality, should one exist. For example: Dist. where the Locality
    /// is Da’an Dist.
    /// </summary>
    public string? LocalityType { get; set; }

    public string? LocalityTypeStatus { get; set; }

    /// <summary>
    /// The WGS 84 longitude in decimal degrees format.
    /// </summary>
    public string? Longitude { get; set; }

    public string? LongitudeStatus { get; set; }

    /// <summary>
    /// Allotment number.
    /// </summary>
    public string? LotNumber { get; set; }

    public string? LotNumberStatus { get; set; }

    /// <summary>
    /// A Makani number is a 10-digit number which gives you the exact location of the entrance
    /// of a building (United Arab Emirates/AE/ARE only). For example: 3000595279.
    /// </summary>
    public string? MakaniNumber { get; set; }

    public string? MakaniNumberStatus { get; set; }

    /// <summary>
    /// The Loqate Engine uses a set of rules to match the input with the reference data. Each
    /// rule is identified by a match rule label. Please refer to the [Match
    /// Process](https://support.loqate.com/support/available-processes/match-process/) and
    /// [Match Rule Syntax](https://support.loqate.com/support/options/match-rules-syntax/) pages
    /// for more information regarding the Match Rules.
    /// </summary>
    public string? MatchRuleLabel { get; set; }

    public string? MatchRuleLabelStatus { get; set; }

    /// <summary>
    /// Defines the census data that is referring to a county or group of closely tied contiguous
    /// counties that serve as a distinct employment region within a metropolitan statistical
    /// area that has a population core of at least 2.5 million. See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for full details.
    /// </summary>
    public string? MetroDivisionCode { get; set; }

    public string? MetroDivisionCodeStatus { get; set; }

    /// <summary>
    /// MetroDivisionName refers to the official name given to the Metropolitan Division which
    /// complements the MetroDivisionCode field value as defined above. For definition of
    /// Metropolitan Division, please refer to the MetroDivisionCode field definition above.
    /// </summary>
    public string? MetroDivisionName { get; set; }

    public string? MetroDivisionNameStatus { get; set; }

    /// <summary>
    /// Defines that the Census data is referring to a county or group of closely tied contiguous
    /// counties that serve as a distinct employment region within a metropolitan statistical
    /// area that has a population core of at least 2.5 million. See
    /// [here](https://support.loqate.com/support/data-enhancement-us-census-data-fields/) for
    /// full details.
    /// </summary>
    public string? MetropolitanDivision { get; set; }

    public string? MetropolitanDivisionStatus { get; set; }

    /// <summary>
    /// DPV Non-Delivery Day Flag that indicates mail delivery is not performed every day of the
    /// week. See [here](https://support.loqate.com/cass2-output-field-descriptions/) for more
    /// details.
    /// </summary>
    public string? NddFlag { get; set; }

    public string? NddFlagStatus { get; set; }

    /// <summary>
    /// DPV Non-Delivery Day Values. This seven-character field represents Sunday-Saturday and
    /// will contain an **N** for the days where mail **can** be delivered. For example,
    /// “YNNNNNY” means mail is is not received on Saturday or Sunday (e.g. the business is
    /// closed).
    /// </summary>
    public string? NddValues { get; set; }

    public string? NddValuesStatus { get; set; }

    /// <summary>
    /// NECTACode refers to a set of geographic areas that are defined using cities and towns in
    /// the six New England states, in typically 5-digits value. See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for full details.
    /// </summary>
    public string? NectaCode { get; set; }

    public string? NectaCodeStatus { get; set; }

    /// <summary>
    /// Defines NECTAs (see definition above) containing a single core with a population of at
    /// least 2.5 million that are subdivided to form smaller groupings of cities and towns
    /// referred to as NECTA Divisions.
    /// </summary>
    public string? NectaDivision { get; set; }

    /// <summary>
    /// NECTA Division defines NECTAs (see definition under NECTACode field above) containing a
    /// single core with a population of at least 2.5 million that are subdivided to form smaller
    /// groupings of cities and towns referred to as NECTA Divisions. NECTADivisionCode is
    /// typically represented in a 5-digits value.
    /// </summary>
    public string? NectaDivisionCode { get; set; }

    public string? NectaDivisionCodeStatus { get; set; }

    /// <summary>
    /// NECTADivisionName refers to the official name given to the NECTA Divisions which
    /// complements the NECTADivisionCode field value as defined above. For definition of NECTA
    /// Division, please refer to the NECTADivisionCode field definition above.
    /// </summary>
    public string? NectaDivisionName { get; set; }

    public string? NectaDivisionNameStatus { get; set; }

    public string? NectaDivisionStatus { get; set; }

    /// <summary>
    /// Defines a set of geographic areas that are defined using cities and towns in the six New
    /// England states. See
    /// [here](https://support.loqate.com/support/data-enhancement-us-census-data-fields/) for
    /// full details.
    /// </summary>
    public string? NectaMetropolitanStatisticalArea { get; set; }

    public string? NectaMetropolitanStatisticalAreaStatus { get; set; }

    /// <summary>
    /// NECTA Micropolitan Statistical Area. See
    /// [here](https://support.loqate.com/support/data-enhancement-us-census-data-fields/) for
    /// full details.
    /// </summary>
    public string? NectaMicropolitanStatisticalArea { get; set; }

    public string? NectaMicropolitanStatisticalAreaStatus { get; set; }

    /// <summary>
    /// NECTAName refers to the official name given to the NECTAs which complements the NECTACode
    /// field value as defined above. See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for full details.
    /// </summary>
    public string? NectaName { get; set; }

    public string? NectaNameStatus { get; set; }

    /// <summary>
    /// Indicates the address is not receiving delivery, and the address is not counted as a
    /// possible delivery. These addresses are not receiving delivery because A) delivery has not
    /// been established; B) customer receives mail as a part of a drop; or C) the address is no
    /// longer a possible delivery because the carrier destroys or returns all the mail. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? NoStatIndicator { get; set; }

    public string? NoStatIndicatorStatus { get; set; }

    /// <summary>
    /// The reason mail delivery was not provided. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? NoStatReason { get; set; }

    public string? NoStatReasonStatus { get; set; }

    /// <summary>
    /// DPV No Secure Location. The door is accessible, but a package will not be left due to
    /// security concerns. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? Nsl { get; set; }

    public string? NslStatus { get; set; }

    /// <summary>
    /// OldMSACode represents an obsolete value of MSA (metropolitan areas) that were defined by
    /// the OMB in 1990. See [here](https://support.loqate.com/us-census-data-enhancement/) for
    /// full details.
    /// </summary>
    public string? OldMsaCode { get; set; }

    public string? OldMsaCodeStatus { get; set; }

    /// <summary>
    /// OldMSAName refers to the official name given to the MSA (metropolitan areas) which
    /// complements the OldMSACode field value as defined above. For definition of MSA, please
    /// refer to the OldMSACode field definition above.
    /// </summary>
    public string? OldMsaName { get; set; }

    public string? OldMsaNameStatus { get; set; }

    /// <summary>
    /// Each Organization that is added to PAF is assigned an 8-digit number that serves as a
    /// unique delivery point when used alongside the AddressKey and PostcodeType. This is useful
    /// to identify small businesses that share an address (the address will appear multiple
    /// times in the PAF). For residential addresses, OrganisationKey is set to 0.
    /// </summary>
    public string? OrganisationKey { get; set; }

    public string? OrganisationKeyStatus { get; set; }

    /// <summary>
    /// The business name associated with a particular delivery point, should one exist.
    /// </summary>
    public string? Organization { get; set; }

    /// <summary>
    /// The name indicator within the Organization field, should one exist. For instance, if
    /// Organization contains ‘Loqate Inc” OrganizationName contains “Loqate” if a sufficient
    /// level of parsing detail exists for the particular country.
    /// </summary>
    public string? OrganizationName { get; set; }

    public string? OrganizationNameStatus { get; set; }

    public string? OrganizationStatus { get; set; }

    /// <summary>
    /// The trailing type indicator contained within the Organization field, should one exist.
    /// For example: Corp., Gmbh.
    /// </summary>
    public string? OrganizationTrailingType { get; set; }

    public string? OrganizationTrailingTypeStatus { get; set; }

    /// <summary>
    /// The type indicator contained within the Organization field, should one exist. For
    /// instance, if Organization contains “Loqate Inc” OrganizationType contains “Inc” if a
    /// sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? OrganizationType { get; set; }

    public string? OrganizationTypeStatus { get; set; }

    /// <summary>
    /// The Owning UDPRN is an eight-digit UDPRN key of the ‘shell’ or ‘owning’ PAF building
    /// record of a Multiple Residence (flat, unit or apartment). For example, if “Ground Floor
    /// Flat, Princes House” is a Multiple Residence record, then “Princes House” would be its
    /// owning building.
    /// </summary>
    public string? OwningUdprn { get; set; }

    public string? OwningUdprnStatus { get; set; }

    /// <summary>
    /// The Parent UPRN is a twelve-digit UPRN of the ‘shell’ or ‘owning’ building of a Multiple
    /// Residence (flat, unit or apartment). Note that this is inferred from the relationships of
    /// an Multi Residence  with a PAF parent address record.
    /// </summary>
    public string? ParentUprn { get; set; }

    public string? ParentUprnStatus { get; set; }

    /// <summary>
    /// This field will capture information that the CASS engine is able to parse out of the
    /// input during the matching process.
    /// </summary>
    public string? ParsedGarbage { get; set; }

    public string? ParsedGarbageStatus { get; set; }

    /// <summary>
    /// PO Box Street Address (PBSA) Indicator: specifies that the mailing address is a PO box.
    /// For example, 131 S Center St # 3094, Collierville TN 38027 is a PO box in the USPS
    /// facility at that address. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? PbsaIndicator { get; set; }

    public string? PbsaIndicatorStatus { get; set; }

    /// <summary>
    /// Private Mailbox Value will be appended to the PrimaryAddressLine field. This information
    /// used to be in SecondaryAddressLine.  For example, this will be the “252“ in “PMB 252“.
    /// </summary>
    public string? PmbNumber { get; set; }

    public string? PmbNumberStatus { get; set; }

    /// <summary>
    /// Private Mailbox Type will be appended to the PrimaryAddressLine field. For  example, if
    /// the Private Mailbox Value was “PMB 100”, then PMBType would be “PMB”. PMBs allow
    /// individuals or offices a private mailbox to simplify internal mail distribution, retain
    /// privacy, or have convenient hours of mail pickup. They can be rented as needed through a
    /// commercial mail receiving agency (CMRA), which may be more cost-effective than renting a
    /// box at the post office.
    /// </summary>
    public string? PmbType { get; set; }

    public string? PmbTypeStatus { get; set; }

    /// <summary>
    /// There is only one ZIP Code for a given facility and the facility has no other form of
    /// postal delivery other than a PO Box. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? PoBoxOnly { get; set; }

    public string? PoBoxOnlyStatus { get; set; }

    /// <summary>
    /// The complete postal code for a particular delivery point, should such detail be able to
    /// be determined.
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// The primary postal code used for a particular country. For instance, USA Zip, Canadian
    /// Postcode, Indian PINcode.
    /// </summary>
    public string? PostalCodePrimary { get; set; }

    public string? PostalCodePrimaryStatus { get; set; }

    /// <summary>
    /// Secondary postal code information, if used in a particular country and if such detail is
    /// able to be determined and reference data is available. For instance, USA Zip Plus 4.
    /// </summary>
    public string? PostalCodeSecondary { get; set; }

    public string? PostalCodeSecondaryStatus { get; set; }

    public string? PostalCodeStatus { get; set; }

    /// <summary>
    /// The post box for a particular delivery point, should one exist.
    /// </summary>
    public string? PostBox { get; set; }

    /// <summary>
    /// Postal delivery number if the address is a postal delivery type.
    /// </summary>
    public string? PostBoxNum { get; set; }

    /// <summary>
    /// The alphanumeric indicator within the PostBox field, should one exist. For instance, if
    /// PostBox contains “PO BOX 1234” PostBoxNumber contains “1234” if a sufficient level of
    /// parsing detail exists for the particular country.
    /// </summary>
    public string? PostBoxNumber { get; set; }

    /// <summary>
    /// Postal delivery number prefix related to the postal delivery number.
    /// </summary>
    public string? PostBoxNumberPrefix { get; set; }

    public string? PostBoxNumberPrefixStatus { get; set; }

    public string? PostBoxNumberStatus { get; set; }

    /// <summary>
    /// Postal delivery number suffix related to the postal delivery number.
    /// </summary>
    public string? PostBoxNumberSuffix { get; set; }

    public string? PostBoxNumberSuffixStatus { get; set; }

    public string? PostBoxNumStatus { get; set; }

    public string? PostBoxStatus { get; set; }

    /// <summary>
    /// The type indicator contained within the PostBox field, should one exist. For instance, if
    /// PostBox contains “PO BOX 1234” PostBoxType contains “PO BOX” if a sufficient level of
    /// parsing detail exists for the particular country.
    /// </summary>
    public string? PostBoxType { get; set; }

    public string? PostBoxTypeStatus { get; set; }

    /// <summary>
    /// This can be one of two values - see
    /// [here](https://support.loqate.com/gb-enhancement-data-fields/) for full details. This
    /// value can also be empty (not assigned).
    /// </summary>
    public string? PostcodeType { get; set; }

    public string? PostcodeTypeStatus { get; set; }

    /// <summary>
    /// The alphanumeric code identifying an individual location, should one exist.
    /// </summary>
    public string? Premise { get; set; }

    /// <summary>
    /// Information that could be present as part of the Premise field. This information is not
    /// considered as part of the Postal authority data but is still necessary for parsing the
    /// address in order to obtain a complete delivery address. Available if a sufficient level
    /// of parsing detail exists within a particular country. Example: In French address, the
    /// Premise number could be followed by words bis and ter which will be considered as Premise
    /// Extra . 25 bis rue Emile Zola, 91190 GIF SUR YVETTE, France. Bis will be considered as
    /// PremiseExtra.
    /// </summary>
    public string? PremiseExtra { get; set; }

    public string? PremiseExtraStatus { get; set; }

    /// <summary>
    /// The alphanumeric indicator within the Premise field, should one exist. For instance, if
    /// Premise contains “Plot 7/7A” PremiseNumber contains “7/7A” if a sufficient level of
    /// parsing detail exists within a particular country.
    /// </summary>
    public string? PremiseNumber { get; set; }

    public string? PremiseNumberStatus { get; set; }

    public string? PremiseStatus { get; set; }

    /// <summary>
    /// The leading premise type indicator within the Premise field, should one exist. For
    /// instance, if Premise contains “Plot 7/7A” PremiseType contains “Plot” if a sufficient
    /// level of parsing detail exists within a particular country.
    /// </summary>
    public string? PremiseType { get; set; }

    public string? PremiseTypeStatus { get; set; }

    /// <summary>
    /// Also known as Barcode Sort Plan (BSP) number. The number of one of 54 individual sort
    /// regions around Australia. To qualify for Australia Post’s PreSort Letters Service,
    /// letters must be sorted based on this number.
    /// </summary>
    public string? PreSortZone { get; set; }

    public string? PreSortZoneStatus { get; set; }

    /// <summary>
    /// Primary address line in standardized format.
    /// </summary>
    public string? PrimaryAddressLine { get; set; }

    public string? PrimaryAddressLineStatus { get; set; }

    /// <summary>
    /// Thoroughfare number for a property (first number in a property ranged address).
    /// </summary>
    public string? PrimaryPremise { get; set; }

    public string? PrimaryPremiseStatus { get; set; }

    /// <summary>
    /// Suffix for the thoroughfare number.
    /// </summary>
    public string? PrimaryPremiseSuffix { get; set; }

    public string? PrimaryPremiseSuffixStatus { get; set; }

    /// <summary>
    /// Also known as a PreSort Indicator. To qualify for Australia Post’s Print Post Service,
    /// letters must be sorted based on this number.
    /// </summary>
    public string? PrintPostZone { get; set; }

    public string? PrintPostZoneStatus { get; set; }

    /// <summary>
    /// See [here](https://support.loqate.com/documentation/fielddescrip/serp-fields/) for full
    /// details.
    /// </summary>
    public string? Questionable { get; set; }

    public string? QuestionableStatus { get; set; }

    /// <summary>
    /// Record type of address that is confirmed as a valid delivery address. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? RecordType { get; set; }

    public string? RecordTypeStatus { get; set; }

    /// <summary>
    /// See [here](https://support.loqate.com/residential-commercial-flag/) for full details.
    /// </summary>
    public string? ResComFlag { get; set; }

    public string? ResComFlagStatus { get; set; }

    /// <summary>
    /// A flag indicating if the address is known to be residential or commercial. Values are “R”
    /// (residential), “C” (commercial), or blank (unknown).
    /// </summary>
    public string? ResidentialCommercialFlag { get; set; }

    public string? ResidentialCommercialFlagStatus { get; set; }

    /// <summary>
    /// This field indicates whether the input address is a residential address or a business
    /// address. See [here](https://support.loqate.com/cass2-output-field-descriptions/) for more
    /// details.
    /// </summary>
    public string? ResidentialDelivery { get; set; }

    public string? ResidentialDeliveryStatus { get; set; }

    /// <summary>
    /// “VALID” for valid addresses. Otherwise, internal error code.
    /// </summary>
    public string? Result { get; set; }

    /// <summary>
    /// Provides information about the process and output address. [View all possible values for
    /// this field](https://support.loqate.com/usa-cass-v2/resultsstring/).
    /// </summary>
    public string? ResultsString { get; set; }

    public string? ResultsStringStatus { get; set; }

    public string? ResultStatus { get; set; }

    /// <summary>
    /// See [here](https://support.loqate.com/cass2-output-field-descriptions/) for full details.
    /// </summary>
    public string? ReturnCode { get; set; }

    public string? ReturnCodeStatus { get; set; }

    /// <summary>
    /// This field is available when adding “SERP” to the Loqate engine. It identifies a Route
    /// Address, such as Rural Route, Military Route. Example value: RR 6.
    /// </summary>
    public string? Route { get; set; }

    /// <summary>
    /// A number that identifies the specific Delivery Mode (Canada/CA/CAN only). Examples
    /// include: 22, 62, 404.
    /// </summary>
    public string? RouteNumber { get; set; }

    public string? RouteNumberStatus { get; set; }

    public string? RouteStatus { get; set; }

    /// <summary>
    /// A code that identifies the type of route service (Canada/CA/CAN only). Examples include:
    /// RR – Rural Route, SS – Suburban Service.
    /// </summary>
    public string? RouteType { get; set; }

    public string? RouteTypeStatus { get; set; }

    /// <summary>
    /// Secondary address line in standardized format.
    /// </summary>
    public string? SecondaryAddressLine { get; set; }

    public string? SecondaryAddressLineStatus { get; set; }

    /// <summary>
    /// Second thoroughfare number (only used if the property has a ranged address eg 23-25).
    /// </summary>
    public string? SecondaryPremise { get; set; }

    public string? SecondaryPremiseStatus { get; set; }

    /// <summary>
    /// Suffix for the second thoroughfare number.
    /// </summary>
    public string? SecondaryPremiseSuffix { get; set; }

    public string? SecondaryPremiseSuffixStatus { get; set; }

    /// <summary>
    /// When multiple addresses are included in a single Verify request this counter will show
    /// the order of the addresses from the input. For example: 7 represents the 7th address in
    /// the input request.
    /// </summary>
    public string? Sequence { get; set; }

    public string? SequenceStatus { get; set; }

    /// <summary>
    /// See [here](https://support.loqate.com/documentation/fielddescrip/serp-fields/) for full
    /// details.
    /// </summary>
    public string? SerpStatusEx { get; set; }

    public string? SerpStatusExStatus { get; set; }

    /// <summary>
    /// A short address that consists of four letters followed by four numbers (Saudi
    /// Arabia/SA/SAU only). For example: RGSA3808.
    /// </summary>
    public string? ShortAddressCode { get; set; }

    public string? ShortAddressCodeStatus { get; set; }

    /// <summary>
    /// StateCode refers to the census data that defines the official geographic (FIPS) code
    /// given to a US state. See [here](https://support.loqate.com/us-census-data-enhancement/)
    /// for full details.
    /// </summary>
    public string? StateCode { get; set; }

    public string? StateCodeStatus { get; set; }

    /// <summary>
    /// The smallest geographic data element within a country. For instance, USA County.
    /// </summary>
    public string? SubAdministrativeArea { get; set; }

    public string? SubAdministrativeAreaStatus { get; set; }

    /// <summary>
    /// The secondary identifiers for a particular delivery point. For instance, “FLAT 1” or
    /// “SUITE 212”.
    /// </summary>
    public string? SubBuilding { get; set; }

    /// <summary>
    /// The secondary identifiers for a particular delivery point. For instance –  BLOQUE 7.
    /// </summary>
    public string? SubBuildingBlock { get; set; }

    public string? SubBuildingBlockStatus { get; set; }

    /// <summary>
    /// The secondary identifiers for a particular delivery point. For instance  PUERTA D.
    /// </summary>
    public string? SubBuildingDoor { get; set; }

    public string? SubBuildingDoorStatus { get; set; }

    /// <summary>
    /// The parsed floor information within the SubBuilding field, and includes the floor label
    /// (or type) and a numeric where applicable. For example, “L7” or “Fl 12”.
    /// </summary>
    public string? SubBuildingFloor { get; set; }

    public string? SubBuildingFloorStatus { get; set; }

    /// <summary>
    /// The sub-building type indicator within the SubBuilding field, should one exist. For
    /// instance, if SubBuilding contains “FLAT 1” SubBuildingLeadingType contains “FLAT” if a
    /// sufficient level of parsing detail exists within a particular country.
    /// </summary>
    public string? SubBuildingLeadingType { get; set; }

    public string? SubBuildingLeadingTypeStatus { get; set; }

    /// <summary>
    /// The descriptive name within the SubBuilding field. For instance, if SubBuilding contains
    /// “BASEMENT FLAT” SubBuildingName contains “BASEMENT FLAT”.
    /// </summary>
    public string? SubBuildingName { get; set; }

    public string? SubBuildingNameStatus { get; set; }

    /// <summary>
    /// The alphanumeric indicator within the SubBuilding field, should one exist. For instance,
    /// if SubBuilding contains “FLAT 1” SubBuildingNumber contains “1” if a sufficient level of
    /// parsing detail exists within a particular country.
    /// </summary>
    public string? SubBuildingNumber { get; set; }

    public string? SubBuildingNumberStatus { get; set; }

    /// <summary>
    /// The secondary identifiers for a particular delivery point. For instance  PUERTA D.
    /// </summary>
    public string? SubBuildingStaircase { get; set; }

    public string? SubBuildingStaircaseStatus { get; set; }

    public string? SubBuildingStatus { get; set; }

    /// <summary>
    /// The leading sub-building type indicator within the SubBuilding field, should one exist.
    /// For instance, if SubBuilding contains “FLAT 1” SubBuildingType contains “FLAT” if a
    /// sufficient level of parsing detail exists within a particular country.
    /// </summary>
    public string? SubBuildingType { get; set; }

    public string? SubBuildingTypeStatus { get; set; }

    /// <summary>
    /// Code returned by SuiteLink®  after querying the SuiteLink® database. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? SuiteLinkFootnote { get; set; }

    public string? SuiteLinkFootnoteStatus { get; set; }

    /// <summary>
    /// The largest geographic data element within a country.
    /// </summary>
    public string? SuperAdministrativeArea { get; set; }

    public string? SuperAdministrativeAreaStatus { get; set; }

    /// <summary>
    /// The most common street or block data element within a country. For instance, USA Street.
    /// </summary>
    public string? Thoroughfare { get; set; }

    /// <summary>
    /// The leading thoroughfare type indicator within the Thoroughfare field, should one exist.
    /// For instance, if Thoroughfare contains “RUE DE LA GARE” ThoroughfareLeadingType contains
    /// “RUE” if a sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? ThoroughfareLeadingType { get; set; }

    public string? ThoroughfareLeadingTypeStatus { get; set; }

    /// <summary>
    /// The name indicator within the Thoroughfare field, should one exist. For instance, if
    /// Thoroughfare contains “N MAIN ST” ThoroughfareName contains “MAIN” if a sufficient level
    /// of parsing detail exists for the particular country.
    /// </summary>
    public string? ThoroughfareName { get; set; }

    public string? ThoroughfareNameStatus { get; set; }

    /// <summary>
    /// The postfix directional contained within the Thoroughfare field, should one exist. For
    /// instance, if Thoroughfare contains “MAIN ST N” ThoroughfarePostDirection contains “N” if
    /// a sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? ThoroughfarePostDirection { get; set; }

    public string? ThoroughfarePostDirectionStatus { get; set; }

    /// <summary>
    /// The prefix directional contained within the Thoroughfare field, should one exist. For
    /// instance, if Thoroughfare contains “N MAIN ST” ThoroughfarePreDirection contains “N” if a
    /// sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? ThoroughfarePreDirection { get; set; }

    public string? ThoroughfarePreDirectionStatus { get; set; }

    public string? ThoroughfareStatus { get; set; }

    /// <summary>
    /// The trailing thoroughfare type indicator within the Thoroughfare field, should one exist.
    /// For instance, if Thoroughfare contains “N MAIN ST” ThoroughfareTrailingType contains “ST”
    /// if a sufficient level of parsing detail exists for the particular country.
    /// </summary>
    public string? ThoroughfareTrailingType { get; set; }

    public string? ThoroughfareTrailingTypeStatus { get; set; }

    /// <summary>
    /// The type of thoroughfare should one exist. Examples include Road, Vei, St, Rua, Avenita,
    /// Pereulok, 路.
    /// </summary>
    public string? ThoroughfareType { get; set; }

    public string? ThoroughfareTypeStatus { get; set; }

    /// <summary>
    /// Residence and business that choose to receive delivery through PO Boxes. No delivery is
    /// made to the street address. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? ThrowbackIndicator { get; set; }

    public string? ThrowbackIndicatorStatus { get; set; }

    /// <summary>
    /// DST defines the Daylight Saving Time. Example: 2869 S County Road 210, Knox IN
    /// 46534-7969, USA Returned DST values: -06:00.
    /// </summary>
    public string? TimeZoneDst { get; set; }

    public string? TimeZoneDstStatus { get; set; }

    /// <summary>
    /// For more information about accessing or using the Time Zone data please contact you
    /// account manager or support.
    /// </summary>
    public string? TimeZoneName { get; set; }

    public string? TimeZoneNameStatus { get; set; }

    /// <summary>
    /// UTC defines the Coordinated Universal Time. Example: 2869 S County Road 210, Knox IN
    /// 46534-7969, USA. Returned UTC values: -05:00.
    /// </summary>
    public string? TimeZoneUtc { get; set; }

    public string? TimeZoneUtcStatus { get; set; }

    /// <summary>
    /// TractCode represents the census data that defines geographic entities within counties,
    /// where each TractCode is typically a 6-digit codes (including any leading zeros, and also
    /// two “trailing” zeros in the many cases in which the basic tract codes has no suffix). See
    /// [here](https://support.loqate.com/us-census-data-enhancement/) for full details.
    /// </summary>
    public string? TractCode { get; set; }

    public string? TractCodeStatus { get; set; }

    /// <summary>
    /// Alternative value for AdministrativeArea, or County, in the United Kingdom. Defined and
    /// supplied by Royal Mail. These values date from the 1800s and were assigned by the
    /// Association of British Counties. E.g. “Gloucestershire”.
    /// </summary>
    public string? TraditionalCounty { get; set; }

    public string? TraditionalCountyStatus { get; set; }

    /// <summary>
    /// The Royal Mail UDPRN, or Unique Delivery Point Reference Number, is an eight-digit
    /// numeric key that is unique to every delivery point record in the PAF. There are some
    /// cases where AddressKeys or OrganisationKeys will change or be re-used, so the UDPRN key
    /// is a more permanent reference to a given delivery point.
    /// </summary>
    public string? UdprnKey { get; set; }

    public string? UdprnKeyStatus { get; set; }

    /// <summary>
    /// The Unique Multiple Residence Reference Number (UMRRN) is an eight-digit numeric key that
    /// is unique to every Multiple Residence (MR).
    /// </summary>
    public string? Umrrn { get; set; }

    public string? UmrrnStatus { get; set; }

    /// <summary>
    /// Any information in the input address fields that is unable to be parsed to a particular
    /// address field. Read more about the Unmatched field
    /// [here](https://support.loqate.com/documentation/fielddescrip/unmatched-field).
    /// </summary>
    public string? Unmatched { get; set; }

    public string? UnmatchedStatus { get; set; }

    /// <summary>
    /// The Unique Property Reference Number (UPRN) is the twelve-digit Ordnance Survey’s unique
    /// record ID for a property and is a persistent ID for a property.
    /// </summary>
    public string? Uprn { get; set; }

    public string? UprnStatus { get; set; }

    /// <summary>
    /// Indicates that the delivery point was active in the past, but is currently vacant (in
    /// most cases, unoccupied over 90 days) and is not receiving deliveries. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? VacantIndicator { get; set; }

    public string? VacantIndicatorStatus { get; set; }

    /// <summary>
    /// ZIP5 Valid Flag: indicates whether the ZIP Code is included in the “Total 5-Digital
    /// Coded” field on the USPS Form 3553. See
    /// [here](https://support.loqate.com/cass2-output-field-descriptions/) for more details.
    /// </summary>
    public string? Zip5Valid { get; set; }

    public string? Zip5ValidStatus { get; set; }
}
