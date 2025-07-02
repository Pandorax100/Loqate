using System.Text.Json.Serialization;

namespace Pandorax.Loqate.Models.Common;

public class Address
{
    public string? Id { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }

    [JsonPropertyName("Address")]
    public string? AddressLine { get; set; }

    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? Address4 { get; set; }
    public string? Address5 { get; set; }
    public string? Address6 { get; set; }
    public string? Address7 { get; set; }
    public string? Address8 { get; set; }
    public string? DeliveryAddress { get; set; }
    public string? DeliveryAddress1 { get; set; }
    public string? DeliveryAddress2 { get; set; }
    public string? DeliveryAddress3 { get; set; }
    public string? DeliveryAddress4 { get; set; }
    public string? DeliveryAddress5 { get; set; }
    public string? DeliveryAddress6 { get; set; }
    public string? DeliveryAddress7 { get; set; }
    public string? DeliveryAddress8 { get; set; }
    public string? SuperAdministrativeArea { get; set; }
    public string? AdministrativeArea { get; set; }
    public string? SubAdministrativeArea { get; set; }
    public string? Locality { get; set; }
    public string? DependentLocality { get; set; }
    public string? DoubleDependentLocality { get; set; }
    public string? Thoroughfare { get; set; }
    public string? DependentThoroughfare { get; set; }
    public string? Building { get; set; }
    public string? Premise { get; set; }
    public string? SubBuilding { get; set; }
    public string? SubBuildingFloor { get; set; }
    public string? PostalCode { get; set; }
    public string? Organization { get; set; }
    public string? PostBox { get; set; }
    public string? Country { get; set; }
    public string? Contact { get; set; }
    public string? Function { get; set; }
    public string? Department { get; set; }
}
