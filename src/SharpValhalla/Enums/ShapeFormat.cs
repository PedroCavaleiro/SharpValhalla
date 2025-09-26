using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Specifies the optional format for the path shape of each connection.
/// Note: Only if format is set to osrm.
/// </summary>
public enum ShapeFormat {
    /// <summary>Polyline6 format.</summary>
    [Description("polyline6")]
    Polyline6,
    /// <summary>Polyline5 format.</summary>
    [Description("polyline5")]
    Polyline5,
    /// <summary>GeoJSON format.</summary>
    [Description("geojson")]
    GeoJson,
    /// <summary>No shape format.</summary>
    [Description("no_shape")]
    NoShape
}