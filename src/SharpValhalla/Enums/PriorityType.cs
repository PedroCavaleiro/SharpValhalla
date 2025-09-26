using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Priority type for matrix calculations.
/// </summary>
public enum PriorityType {
    /// <summary>
    /// Prioritize by travel time.
    /// </summary>
    [Description("time")]
    Time,
    /// <summary>
    /// Prioritize by distance.
    /// </summary>
    [Description("distance")]
    Distance
}