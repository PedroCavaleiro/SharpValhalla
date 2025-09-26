using System.Text.Json.Serialization;

// ReSharper disable ClassNeverInstantiated.Global

namespace SharpValhalla.Models.Response;

/// <summary>
/// Represents a single leg within a route, containing its maneuvers,
/// an optional summary, and an optional encoded shape.
/// </summary>
public class LegResponse {
    /// <summary>
    /// An array of maneuvers for the leg, if present.
    /// </summary>
    [JsonPropertyName("maneuvers")]
    public List<ManeuverResponse>? Maneuvers { get; set; }

    /// <summary>
    /// Summary information for the leg, if present.
    /// </summary>
    [JsonPropertyName("summary")]
    public SummaryResponse? Summary { get; set; }

    /// <summary>
    /// Encoded polyline/string representing the leg's geometry, if present.
    /// </summary>
    [JsonPropertyName("shape")]
    public string? Shape { get; set; }
}