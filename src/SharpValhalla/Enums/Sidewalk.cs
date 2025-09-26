using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the presence and location of sidewalks for edges in Valhalla routing.
///
/// Each case corresponds to the sidewalk position relative to the edge.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum Sidewalk {
    /// <summary>Sidewalk is on the left side of the edge.</summary>
    [Description("left")]
    Left,
    /// <summary>Sidewalk is on the right side of the edge.</summary>
    [Description("right")]
    Right,
    /// <summary>Sidewalks are present on both sides of the edge.</summary>
    [Description("both")]
    Both
}

/// <summary>
/// Alias for Sidewalk to represent the side of street, matching the Swift typealias.
/// </summary>
public enum SideOfStreet {
    Left = Sidewalk.Left,
    Right = Sidewalk.Right,
    Both = Sidewalk.Both
}