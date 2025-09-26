using System.Text.Json.Serialization;

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Response;

/// <summary>
/// Transit route information for a transit leg, including identifiers, names, colors, operator info, and stops.
/// </summary>
public class TransitInfo {
    /// <summary>
    /// OneStop identifier for the transit route.
    /// </summary>
    [JsonPropertyName("onestop_id")]
    public string OneStopId { get; set; } = string.Empty;

    /// <summary>
    /// Short name of the route.
    /// </summary>
    [JsonPropertyName("short_name")]
    public string ShortName { get; set; } = string.Empty;

    /// <summary>
    /// Long name of the route.
    /// </summary>
    [JsonPropertyName("long_name")]
    public string LongName { get; set; } = string.Empty;

    /// <summary>
    /// Headsign displayed for the transit service.
    /// </summary>
    [JsonPropertyName("headsign")]
    public string Headsign { get; set; } = string.Empty;

    /// <summary>
    /// Route color as an integer.
    /// </summary>
    [JsonPropertyName("color")]
    public int Color { get; set; }

    /// <summary>
    /// Text color as an integer.
    /// </summary>
    [JsonPropertyName("text_color")]
    public int TextColor { get; set; }

    /// <summary>
    /// Route description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Operator OneStop identifier.
    /// </summary>
    [JsonPropertyName("operator_onestop_id")]
    public string OperatorOnestopId { get; set; } = string.Empty;

    /// <summary>
    /// Operator human-readable name.
    /// </summary>
    [JsonPropertyName("operator_name")]
    public string OperatorName { get; set; } = string.Empty;

    /// <summary>
    /// Operator website URL.
    /// </summary>
    [JsonPropertyName("operator_url")]
    public string OperatorUrl { get; set; } = string.Empty;

    /// <summary>
    /// Array of stops for this transit route.
    /// </summary>
    [JsonPropertyName("transit_stops")]
    public List<TransitStop> TransitStops { get; set; } = new();

    /// <summary>
    /// Default constructor for deserialization.
    /// </summary>
    public TransitInfo() {}

    /// <summary>
    /// Constructor for all properties.
    /// </summary>
    public TransitInfo(
        string            onestopId,
        string            shortName,
        string            longName,
        string            headsign,
        int               color,
        int               textColor,
        string            description,
        string            operatorOnestopId,
        string            operatorName,
        string            operatorUrl,
        List<TransitStop> transitStops
    ) {
        OneStopId         = onestopId;
        ShortName         = shortName;
        LongName          = longName;
        Headsign          = headsign;
        Color             = color;
        TextColor         = textColor;
        Description       = description;
        OperatorOnestopId = operatorOnestopId;
        OperatorName      = operatorName;
        OperatorUrl       = operatorUrl;
        TransitStops      = transitStops;
    }
}