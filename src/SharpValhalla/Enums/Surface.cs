using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the different surface types for edges in Valhalla routing.
///
/// Each case corresponds to a specific surface quality or condition.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum Surface {
    /// <summary>Paved smooth surface.</summary>
    [Description("paved_smooth")]
    PavedSmooth,
    /// <summary>Paved surface.</summary>
    [Description("paved")]
    Paved,
    /// <summary>Paved rough surface.</summary>
    [Description("paved_rough")]
    PavedRough,
    /// <summary>Compacted surface.</summary>
    [Description("compacted")]
    Compacted,
    /// <summary>Dirt surface.</summary>
    [Description("dirt")]
    Dirt,
    /// <summary>Gravel surface.</summary>
    [Description("gravel")]
    Gravel,
    /// <summary>Path surface.</summary>
    [Description("path")]
    Path,
    /// <summary>Impassable surface.</summary>
    [Description("impassable")]
    Impassable
}