using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the possible states of a location when aligning a trace to the road network.
/// </summary>
public enum MatchedType {
    /// <summary>
    /// The trace point could not be aligned to any road segment.
    /// </summary>
    [Description("unmatched")]
    Unmatched,
    /// <summary>
    /// The trace point was interpolated between known matched points.
    /// </summary>
    [Description("interpolated")]
    Interpolated,
    /// <summary>
    /// The trace point was successfully matched to a road segment.
    /// </summary>
    [Description("matched")]
    Matched
}