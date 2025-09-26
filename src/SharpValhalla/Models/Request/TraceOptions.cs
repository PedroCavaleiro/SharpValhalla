using System.Text.Json.Serialization;
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global

namespace SharpValhalla.Models.Request;

/// <summary>
/// Additional options to the trace.
/// </summary>
public class TraceOptions {
    /// <summary>
    /// Search radius in meters associated with supplied trace points.
    /// </summary>
    [JsonPropertyName("search_radius")]
    public int? SearchRadius { get; set; }

    /// <summary>
    /// GPS accuracy in meters associated with supplied trace points.
    /// </summary>
    [JsonPropertyName("gps_accuracy")]
    public int? GpsAccuracy { get; set; }

    /// <summary>
    /// Breaking distance in meters between trace points.
    /// </summary>
    [JsonPropertyName("breakage_distance")]
    public int? BreakageDistance { get; set; }

    /// <summary>
    /// Interpolation distance in meters beyond which trace points are merged together.
    /// </summary>
    [JsonPropertyName("interpolation_distance")]
    public int? InterpolationDistance { get; set; }

    /// <summary>
    /// Initializer for TraceOptions.
    /// </summary>
    /// <param name="searchRadius">Search radius in meters associated with supplied trace points.</param>
    /// <param name="gpsAccuracy">GPS accuracy in meters associated with supplied trace points.</param>
    /// <param name="breakageDistance">Breaking distance in meters between trace points.</param>
    /// <param name="interpolationDistance">Interpolation distance in meters beyond which trace points are merged together.</param>
    public TraceOptions(int? searchRadius = null, int? gpsAccuracy = null, int? breakageDistance = null, int? interpolationDistance = null) {
        SearchRadius = searchRadius;
        GpsAccuracy = gpsAccuracy;
        BreakageDistance = breakageDistance;
        InterpolationDistance = interpolationDistance;
    }
}