using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents possible lane directions as a bitmask.
///
/// This type is a bitmask enum, which means multiple directions can be combined using bitwise operations.
///
/// Example:
/// <code>
/// // A lane that allows both going straight and turning left
/// var lane = LaneDirection.Through | LaneDirection.Left;
///
/// // Checking if a lane includes a left turn
/// if ((lane & LaneDirection.Left) == LaneDirection.Left) {
///     Console.WriteLine("This lane allows a left turn");
/// }
///
/// // Checking for multiple directions
/// if ((lane & (LaneDirection.Through | LaneDirection.Left)) == (LaneDirection.Through | LaneDirection.Left)) {
///     Console.WriteLine("This lane allows straight and left");
/// }
/// </code>
///
/// Use LaneDirection.All to access every possible lane direction, e.g. for validation or iteration.
/// </summary>
[Flags]
public enum LaneDirection {
    /// <summary>
    /// Empty - No turn lane or undefined
    /// </summary>
    [Description("empty")]
    Empty = 0,
    /// <summary>
    /// None - No specific direction
    /// </summary>
    [Description("none")]
    None = 1,
    /// <summary>
    /// Through - Goes straight
    /// </summary>
    [Description("through")]
    Through = 2,
    /// <summary>
    /// SharpLeft - Turns sharply to the left
    /// </summary>
    [Description("sharpLeft")]
    SharpLeft = 4,
    /// <summary>
    /// Left - Turns left
    /// </summary>
    [Description("left")]
    Left = 8,
    /// <summary>
    /// SlightLeft - Turns slightly to the left
    /// </summary>
    [Description("slightLeft")]
    SlightLeft = 16,
    /// <summary>
    /// SlightRight - Turns slightly to the right
    /// </summary>
    [Description("slightRight")]
    SlightRight = 32,
    /// <summary>
    /// Right - Turns right
    /// </summary>
    [Description("right")]
    Right = 64,
    /// <summary>
    /// SharpRight - Turns sharply to the right
    /// </summary>
    [Description("sharpRight")]
    SharpRight = 128,
    /// <summary>
    /// Reverse - U-turn
    /// </summary>
    [Description("reverse")]
    Reverse = 256,
    /// <summary>
    /// MergeToLeft - Lane merges to the left
    /// </summary>
    [Description("mergeToLeft")]
    MergeToLeft = 512,
    /// <summary>
    /// MergeToRight - Lane merges to the right
    /// </summary>
    [Description("mergeToRight")]
    MergeToRight = 1024
}

/// <summary>
/// Helper class for LaneDirection to provide all possible values.
/// </summary>
public static class LaneDirectionHelper {
    public static readonly LaneDirection[] All = [
        LaneDirection.Empty,
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
}