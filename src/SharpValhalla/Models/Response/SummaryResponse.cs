using System.Text.Json.Serialization;
// ReSharper disable ClassNeverInstantiated.Global

namespace SharpValhalla.Models.Response;

/// <summary>
/// Summary information for a route or leg, including time, length,
/// bounding box coordinates, and cost flags.
/// </summary>
public class SummaryResponse {
    /// <summary>
    /// Total time in seconds.
    /// </summary>
    [JsonPropertyName("time")]
    public double? Time { get; set; }

    /// <summary>
    /// Total length in meters.
    /// </summary>
    [JsonPropertyName("length")]
    public double? Length { get; set; }

    /// <summary>
    /// Whether the route includes tolls.
    /// </summary>
    [JsonPropertyName("has_toll")]
    public bool? HasToll { get; set; }

    /// <summary>
    /// Whether the route includes ferries.
    /// </summary>
    [JsonPropertyName("has_ferry")]
    public bool? HasFerry { get; set; }

    /// <summary>
    /// Whether the route includes highways.
    /// </summary>
    [JsonPropertyName("has_highway")]
    public bool? HasHighway { get; set; }

    /// <summary>
    /// Whether the route includes time restrictions.
    /// </summary>
    [JsonPropertyName("has_time_restrictions")]
    public bool? HasTimeRestrictions { get; set; }

    /// <summary>
    /// Minimum latitude of the route bounding box.
    /// </summary>
    [JsonPropertyName("min_lat")]
    public double? MinimumLatitude { get; set; }

    /// <summary>
    /// Minimum longitude of the route bounding box.
    /// </summary>
    [JsonPropertyName("min_lon")]
    public double? MinimumLongitude { get; set; }

    /// <summary>
    /// Maximum latitude of the route bounding box.
    /// </summary>
    [JsonPropertyName("max_lat")]
    public double? MaximumLatitude { get; set; }

    /// <summary>
    /// Maximum longitude of the route bounding box.
    /// </summary>
    [JsonPropertyName("max_lon")]
    public double? MaximumLongitude { get; set; }

    /// <summary>
    /// Cost metric for the route.
    /// </summary>
    [JsonPropertyName("cost")]
    public double Cost { get; set; }
}