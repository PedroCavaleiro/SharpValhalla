using System.Text.Json.Serialization;
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ClassNeverInstantiated.Global

namespace SharpValhalla.Models.Response;

/// <summary>
/// Represents a single element in the matrix result.
/// Each matrix element contains the computed time and distance between a source and target location. If no route can be found, the element will be null in the response.
/// </summary>
public class MatrixElement {
    /// <summary>
    /// Travel time in seconds
    /// </summary>
    [JsonPropertyName("time")]
    public double Time { get; set; }

    /// <summary>
    /// Travel distance in the units specified in the request (kilometers or miles)
    /// </summary>
    [JsonPropertyName("distance")]
    public double Distance { get; set; }

    /// <summary>
    /// Distance from the target input coordinate to the graph edge in meters
    /// </summary>
    [JsonPropertyName("to_edge_distance")]
    public double? ToEdgeDistance { get; set; }

    /// <summary>
    /// Distance from the source input coordinate to the graph edge in meters
    /// </summary>
    [JsonPropertyName("from_edge_distance")]
    public double? FromEdgeDistance { get; set; }

    /// <summary>
    /// Constructor for MatrixElement.
    /// </summary>
    public MatrixElement(
        double  time,
        double  distance,
        double? toEdgeDistance   = null,
        double? fromEdgeDistance = null
    ) {
        Time             = time;
        Distance         = distance;
        ToEdgeDistance   = toEdgeDistance;
        FromEdgeDistance = fromEdgeDistance;
    }
}