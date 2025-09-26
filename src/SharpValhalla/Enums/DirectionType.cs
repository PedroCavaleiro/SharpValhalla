using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Indicates the type of directions or instructions to be returned.
/// </summary>
public enum DirectionType {
    /// <summary>
    /// Indicating no maneuvers or instructions should be returned.
    /// </summary>
    [Description("none")]
    None,
    /// <summary>
    /// Indicating that only maneuvers be returned.
    /// </summary>
    [Description("maneuvers")]
    Maneuvers,
    /// <summary>
    /// Indicating that maneuvers with instructions should be returned (this is the default if not specified).
    /// </summary>
    [Description("instructions")]
    Instructions
}