using System.Text.Json.Serialization;
using SharpValhalla.Enums;

// ReSharper disable ClassNeverInstantiated.Global

namespace SharpValhalla.Models.Response;

/// <summary>
/// Represents a road lane with its supported directions and metadata about
/// whether the lane is currently active or valid for a maneuver.
/// </summary>
public class Lane {
    /// <summary>
    /// The directions that the lane supports.
    /// </summary>
    [JsonPropertyName("directions")]
    public LaneDirection Directions { get; set; }

    /// <summary>
    /// The currently active direction(s) for the lane, if any.
    /// </summary>
    [JsonPropertyName("active")]
    public LaneDirection? Active { get; set; }

    /// <summary>
    /// The direction(s) considered valid for the maneuver, if any.
    /// </summary>
    [JsonPropertyName("valid")]
    public LaneDirection? Valid { get; set; }
}