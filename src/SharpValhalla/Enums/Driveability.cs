using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the allowed driving directions for an edge in Valhalla routing.
/// Each case corresponds to the permitted direction(s) of travel along an edge.
///
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum Driveability {
    /// <summary>
    /// Travel is allowed only in the forward direction.
    /// </summary>
    [Description("forward")]
    Forward,
    /// <summary>
    /// Travel is allowed only in the backward direction.
    /// </summary>
    [Description("backward")]
    Backward,
    /// <summary>
    /// Travel is allowed in both directions.
    /// </summary>
    [Description("both")]
    Both
}

/// <summary>
/// Aliases for Driveability to represent the allowed travel directions for different modes of movement.
/// Traversability: Directional access for vehicles along an edge.
/// Cyclability: Directional access for bicycles along an edge.
/// Walkability: Directional access for pedestrians along an edge.
/// </summary>
public enum Traversability {
    Forward = Driveability.Forward,
    Backward = Driveability.Backward,
    Both = Driveability.Both
}

public enum Cyclability {
    Forward = Driveability.Forward,
    Backward = Driveability.Backward,
    Both = Driveability.Both
}

public enum Walkability {
    Forward = Driveability.Forward,
    Backward = Driveability.Backward,
    Both = Driveability.Both
}