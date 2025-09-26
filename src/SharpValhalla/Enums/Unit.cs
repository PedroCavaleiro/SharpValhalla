using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Distance units for output. Allowable unit types are miles (or mi) and kilometers (or km). If no unit type is specified, the units default to kilometers.
/// </summary>
public enum Unit {
    /// <summary>Miles (mi).</summary>
    [Description("mi")]
    Miles,
    /// <summary>Kilometers (km).</summary>
    [Description("km")]
    Kilometers
}