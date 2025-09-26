using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents different bicycle types for edges in Valhalla routing.
///
/// Each case corresponds to a specific type of bicycle or cycling preference.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum BicycleType {
    /// <summary>
    /// Road bicycle type.
    /// </summary>
    [Description("road")]
    Road,
    /// <summary>
    /// Cross bicycle type.
    /// </summary>
    [Description("cross")]
    Cross,
    /// <summary>
    /// Hybrid bicycle type.
    /// </summary>
    [Description("hybrid")]
    Hybrid,
    /// <summary>
    /// Mountain bicycle type.
    /// </summary>
    [Description("mountain")]
    Mountain
}