using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents different pedestrian types for edges in Valhalla routing.
///
/// Each case corresponds to a specific type of pedestrian or mobility mode.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum PedestrianType {
    /// <summary>Standard pedestrian (foot).</summary>
    [Description("foot")]
    Foot,
    /// <summary>Wheelchair user.</summary>
    [Description("wheelchair")]
    Wheelchair,
    /// <summary>Segway user.</summary>
    [Description("segway")]
    Segway
}