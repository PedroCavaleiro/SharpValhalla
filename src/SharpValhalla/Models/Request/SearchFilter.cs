using System.Text.Json.Serialization;
using SharpValhalla.Enums;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Request;

/// <summary>
/// A set of optional filters to exclude candidate edges based on their attribution.
/// </summary>
public class SearchFilter {
    [JsonPropertyName("exclude_tunnel")]
    public bool ExcludeTunnel { get; set; }
    [JsonPropertyName("exclude_bridge")]
    public bool ExcludeBridge { get; set; }
    [JsonPropertyName("exclude_toll")]
    public bool ExcludeToll { get; set; }
    [JsonPropertyName("exclude_ferry")]
    public bool ExcludeFerry { get; set; }
    [JsonPropertyName("exclude_ramp")]
    public bool ExcludeRamp { get; set; }
    [JsonPropertyName("exclude_closures")]
    public bool ExcludeClosures { get; set; }
    [JsonPropertyName("min_road_class")]
    public RoadClass MinRoadClass { get; set; }
    [JsonPropertyName("max_road_class")]
    public RoadClass MaxRoadClass { get; set; }

    /// <summary>
    /// Initializer with all default values.
    /// </summary>
    public SearchFilter(
        bool excludeTunnel = false,
        bool excludeBridge = false,
        bool excludeToll = false,
        bool excludeFerry = false,
        bool excludeRamp = false,
        bool excludeClosures = true,
        RoadClass minRoadClass = RoadClass.ServiceOther,
        RoadClass maxRoadClass = RoadClass.Motorway
    ) {
        ExcludeTunnel = excludeTunnel;
        ExcludeBridge = excludeBridge;
        ExcludeToll = excludeToll;
        ExcludeFerry = excludeFerry;
        ExcludeRamp = excludeRamp;
        ExcludeClosures = excludeClosures;
        MinRoadClass = minRoadClass;
        MaxRoadClass = maxRoadClass;
    }
}