using SharpValhalla.Enums;

// ReSharper disable MemberCanBePrivate.Global

namespace SharpValhalla.Extensions;

/// <summary>
/// Utility extensions for LaneDirection providing convenience collections
/// and readable descriptions for direction bitmasks used by lane models.
/// </summary>
public static class LaneDirectionExtensions {
    
    /// <summary>
    /// Enumerates all known lane directions (excluding Empty).
    /// </summary>
    public static readonly LaneDirection[] AllCases = [
        LaneDirection.None,
        LaneDirection.Through,
        LaneDirection.SharpLeft,
        LaneDirection.Left,
        LaneDirection.SlightLeft,
        LaneDirection.SlightRight,
        LaneDirection.Right,
        LaneDirection.SharpRight,
        LaneDirection.Reverse,
        LaneDirection.MergeToLeft,
        LaneDirection.MergeToRight
    ];

    /// <summary>
    /// Returns all directions contained in this bitmask.
    /// </summary>
    public static LaneDirection[] Components(this LaneDirection value) =>
        AllCases.Where(dir => (value & dir) == dir).ToArray();

    /// <summary>
    /// Returns a human-readable representation of the lane direction bitmask.
    /// </summary>
    public static string Description(this LaneDirection value) {
        
        var parts = new List<string>();
        if ((value & LaneDirection.None) == LaneDirection.None) parts.Add("None");
        if ((value & LaneDirection.Through) == LaneDirection.Through) parts.Add("Through");
        if ((value & LaneDirection.SharpLeft) == LaneDirection.SharpLeft) parts.Add("SharpLeft");
        if ((value & LaneDirection.Left) == LaneDirection.Left) parts.Add("Left");
        if ((value & LaneDirection.SlightLeft) == LaneDirection.SlightLeft) parts.Add("SlightLeft");
        if ((value & LaneDirection.SlightRight) == LaneDirection.SlightRight) parts.Add("SlightRight");
        if ((value & LaneDirection.Right) == LaneDirection.Right) parts.Add("Right");
        if ((value & LaneDirection.SharpRight) == LaneDirection.SharpRight) parts.Add("SharpRight");
        if ((value & LaneDirection.Reverse) == LaneDirection.Reverse) parts.Add("Reverse");
        if ((value & LaneDirection.MergeToLeft) == LaneDirection.MergeToLeft) parts.Add("MergeToLeft");
        if ((value & LaneDirection.MergeToRight) == LaneDirection.MergeToRight) parts.Add("MergeToRight");
        
        return parts.Count == 0 ? "Empty" : string.Join(" + ", parts);
    }
}

