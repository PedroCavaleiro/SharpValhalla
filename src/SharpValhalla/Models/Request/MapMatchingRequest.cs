using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Diagnostics;
using SharpValhalla.Enums;
using SharpValhalla.Models.Common;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Request;

/// <summary>
/// The structure for the Map Matching request.
/// </summary>
public class MapMatchingRequest {
    [JsonPropertyName("shape")]
    public List<Location>? Shape { get; set; }
    [JsonPropertyName("encoded_polyline")]
    public string? EncodedPolyline { get; set; }
    [JsonPropertyName("shape_match")]
    public ShapeMatch ShapeMatch { get; set; }
    [JsonPropertyName("costing")]
    public CostingModel Costing { get; set; }
    [JsonPropertyName("use_timestamps")]
    public bool UseTimestamps { get; set; }
    [JsonPropertyName("directions_options")]
    public DirectionsOptions? DirectionsOptions { get; set; }
    [JsonPropertyName("trace_options")]
    public TraceOptions? TraceOptions { get; set; }
    [JsonPropertyName("begin_time")]
    public int? BeginTime { get; set; }
    [JsonPropertyName("durations")]
    public List<int>? Durations { get; set; }
    [JsonPropertyName("filters")]
    public TraceAttributesFilter? Filters { get; set; }

    /// <summary>
    /// The structure for the Map Matching request.
    /// </summary>
    /// <param name="shape">The shape to match</param>
    /// <param name="encodedPolyline">The polyline to match</param>
    /// <param name="shapeMatch">Allows some control of the matching algorithm based on the type of input.</param>
    /// <param name="costing">Valhalla Map Matching can use any costing model available in the Valhalla route service</param>
    /// <param name="useTimestamps">A boolean value indicating whether the input timestamps or durations should be used when computing elapsed time at each edge along the matched path. If true, timestamps are used. If false (default), internal costing is applied to compute elapsed times.</param>
    /// <param name="directionsOptions">Specify units, language, and whether or not to return directions in a narrative form.</param>
    /// <param name="traceOptions">Trace options to improve results</param>
    /// <param name="beginTime">Begin timestamp for the trace. This is used along with the durations so that timestamps can be specified for a trace that is specified using an encoded polyline.</param>
    /// <param name="durations">List of durations (seconds) between each successive pair of input trace points. This allows trace points to be supplied as an encoded polyline and timestamps to be created by using this list of "delta" times along with the beginTime of the trace.</param>
    /// <param name="filters">The trace attributes filters for this request</param>
    /// <exception cref="ArgumentException">Thrown if neither shape nor encodedPolyline is provided.</exception>
    public MapMatchingRequest(
        List<Location>? shape = null,
        string? encodedPolyline = null,
        ShapeMatch shapeMatch = ShapeMatch.WalkOrSnap,
        CostingModel costing = CostingModel.Auto,
        bool useTimestamps = false,
        DirectionsOptions? directionsOptions = null,
        TraceOptions? traceOptions = null,
        int? beginTime = null,
        List<int>? durations = null,
        TraceAttributesFilter? filters = null
    ) {
        ShapeMatch = shapeMatch;
        Costing = costing;
        UseTimestamps = useTimestamps;
        DirectionsOptions = directionsOptions;
        TraceOptions = traceOptions;
        Filters = filters;
        if (durations != null && beginTime != null) {
            Durations = durations;
            BeginTime = beginTime;
        } else {
            Durations = null;
            BeginTime = null;
        }
        if (shape != null) {
            Shape = shape;
            EncodedPolyline = null;
        } else if (encodedPolyline != null) {
            Shape = null;
            EncodedPolyline = encodedPolyline;
        } else {
            throw new ArgumentException("Must supply either shape or encodedPolyline");
        }
    }
}