using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents different transit types for edges in Valhalla routing.
///
/// Each case corresponds to a specific public transit or cable transport type.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum TransitType {
    /// <summary>Tram transit type.</summary>
    [Description("tram")]
    Tram,
    /// <summary>Metro transit type.</summary>
    [Description("metro")]
    Metro,
    /// <summary>Rail transit type.</summary>
    [Description("rail")]
    Rail,
    /// <summary>Bus transit type.</summary>
    [Description("bus")]
    Bus,
    /// <summary>Ferry transit type.</summary>
    [Description("ferry")]
    Ferry,
    /// <summary>Cable car transit type.</summary>
    [Description("cable_car")]
    CableCar,
    /// <summary>Gondola transit type.</summary>
    [Description("gondola")]
    Gondola,
    /// <summary>Funicular transit type.</summary>
    [Description("funicular")]
    Funicular
}