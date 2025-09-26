using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the different travel modes for edges in Valhalla routing.
///
/// Each case corresponds to a specific mode of transportation.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum TravelMode {
    /// <summary>Drive mode of transportation.</summary>
    [Description("drive")]
    Drive,
    /// <summary>Pedestrian mode of transportation.</summary>
    [Description("pedestrian")]
    Pedestrian,
    /// <summary>Bicycle mode of transportation.</summary>
    [Description("bicycle")]
    Bicycle,
    /// <summary>Transit mode of transportation.</summary>
    [Description("transit")]
    Transit
}