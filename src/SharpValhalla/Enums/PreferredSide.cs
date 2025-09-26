using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Indicates the preferred side relative to a reference (for example,
/// which side of the road a route or asset prefers).
/// </summary>
public enum PreferredSide {
    /// <summary>
    /// Prefer the same side as the reference.
    /// </summary>
    [Description("same")]
    Same,
    /// <summary>
    /// Prefer the opposite side from the reference.
    /// </summary>
    [Description("opposite")]
    Opposite,
    /// <summary>
    /// Either side is acceptable.
    /// </summary>
    [Description("either")]
    Either
}