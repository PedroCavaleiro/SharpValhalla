using System.Text.Json.Serialization;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Common;

/// <summary>
/// Represents a geographic coordinate with latitude and longitude.
/// </summary>
public class LocationCoordinate2D(double latitude, double longitude) {
    /// <summary>
    /// Latitude component of the coordinate.
    /// </summary>
    [JsonPropertyName("lat")]
    public double Latitude { get; set; } = latitude;

    /// <summary>
    /// Longitude component of the coordinate.
    /// </summary>
    [JsonPropertyName("lon")]
    public double Longitude { get; set; } = longitude;
}