using System.Text.Json.Serialization;
using SharpValhalla.Models.Common;

namespace SharpValhalla.Models.Response;

/// <summary>
/// Represents a route/trip response returned by a routing service, including status, language/units, and optional summary/legs/locations.
/// </summary>
public class RouteResponse {
    /// <summary>
    /// Numeric status code for the response.
    /// </summary>
    [JsonPropertyName("status")]
    public int Status { get; set; }

    /// <summary>
    /// Human-readable status message.
    /// </summary>
    [JsonPropertyName("status_message")]
    public string StatusMessage { get; set; } = string.Empty;

    /// <summary>
    /// Units used in the response (e.g., metric/imperial).
    /// </summary>
    [JsonPropertyName("units")]
    public string Units { get; set; } = string.Empty;

    /// <summary>
    /// Language code used for textual responses.
    /// </summary>
    [JsonPropertyName("language")]
    public string Language { get; set; } = string.Empty;

    /// <summary>
    /// Optional overall route summary.
    /// </summary>
    [JsonPropertyName("summary")]
    public SummaryResponse? Summary { get; set; }

    /// <summary>
    /// Optional array of legs for the route.
    /// </summary>
    [JsonPropertyName("legs")]
    public List<LegResponse>? Legs { get; set; }

    /// <summary>
    /// Optional array of locations associated with the route.
    /// </summary>
    [JsonPropertyName("locations")]
    public List<Location>? Locations { get; set; }
}