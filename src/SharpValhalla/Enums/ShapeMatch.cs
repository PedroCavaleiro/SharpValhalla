using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// It allows some control of the matching algorithm based on the type of input.
/// </summary>
public enum ShapeMatch {
    /// <summary>
    /// Indicates an edge walking algorithm can be used. This algorithm requires nearly exact shape matching, so it should only be used when the shape is from a prior Valhalla route.
    /// </summary>
    [Description("edge_walk")]
    EdgeWalk,
    /// <summary>
    /// Indicates that a map-matching algorithm should be used because the input shape might not closely match Valhalla edges. This algorithm is more expensive.
    /// </summary>
    [Description("map_snap")]
    MapSnap,
    /// <summary>
    /// Also the default option. This will try edge walking and if this does not succeed, it will fall back and use map matching.
    /// </summary>
    [Description("walk_or_snap")]
    WalkOrSnap
}