using System.Text.Json.Serialization;

// ReSharper disable ClassNeverInstantiated.Global

namespace SharpValhalla.Models.Response.BaseResponses;

/// <summary>
/// Represents an alternate route option in the map matching response.
/// </summary>
public class AlternateResponse {
    [JsonPropertyName("trip")]
    public RouteResponse Trip { get; set; } = new();
}

/// <summary>
/// Represents the response for a map matching request.
/// </summary>
public class MapMatchingResponse {
    /// <summary>
    /// The main matched trip response.
    /// </summary>
    [JsonPropertyName("trip")]
    public RouteResponse Trip { get; set; } = new();

    /// <summary>
    /// Optional alternate trip responses.
    /// </summary>
    [JsonPropertyName("alternates")]
    public List<AlternateResponse>? Alternates { get; set; }
}