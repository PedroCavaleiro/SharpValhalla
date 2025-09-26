using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Directions response format.
/// </summary>
public enum Format {
    /// <summary>
    /// Is default Valhalla routing directions JSON format.
    /// </summary>
    [Description("json")]
    Json,
    /// <summary>
    /// Returns the route as a GPX (GPS exchange format) XML track.
    /// </summary>
    [Description("gpx")]
    Gpx,
    /// <summary>
    /// Creates an OSRM compatible route directions JSON.
    /// </summary>
    [Description("osrm")]
    Osrm,
    /// <summary>
    /// Formats the result using protocol buffers.
    /// </summary>
    [Description("pbf")]
    Pbf
}