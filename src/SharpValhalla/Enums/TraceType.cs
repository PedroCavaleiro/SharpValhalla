using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Each type controls two characteristics: whether or not to allow a u-turn at the location and whether or not to generate guidance/legs at the location.
/// </summary>
public enum TraceType {
    /// <summary>
    /// A break is a location at which we allow u-turns and generate legs and arrival/departure maneuvers.
    /// </summary>
    [Description("break")]
    Break,
    /// <summary>
    /// A via location is a location at which we allow u-turns but do not generate legs or arrival/departure maneuvers.
    /// </summary>
    [Description("via")]
    Via,
    /// <summary>
    /// A through location is a location at which we neither allow u-turns nor generate legs or arrival/departure maneuvers.
    /// </summary>
    [Description("through")]
    Through,
    /// <summary>
    /// A breakThrough location is a location at which we do not allow u-turns but do generate legs and arrival/departure maneuvers.
    /// </summary>
    [Description("break_through")]
    BreakThrough
}