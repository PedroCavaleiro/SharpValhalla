using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the SAC (Swiss Alpine Club) scale for hiking difficulty.
///
/// Each case corresponds to a specific level of hiking difficulty.
/// The raw value matches the numeric string used in Valhalla.
/// </summary>
public enum SacScale {
    /// <summary>No Sac Scale</summary>
    [Description("0")]
    NoSacScale,
    /// <summary>Hiking</summary>
    [Description("1")]
    Hiking,
    /// <summary>Mountain hiking</summary>
    [Description("2")]
    MountainHiking,
    /// <summary>Demanding mountain hiking</summary>
    [Description("3")]
    DemandingMountainHiking,
    /// <summary>Alpine hiking</summary>
    [Description("4")]
    AlpineHiking,
    /// <summary>Demanding alpine hiking</summary>
    [Description("5")]
    DemandingAlpineHiking,
    /// <summary>Difficult alpine hiking</summary>
    [Description("6")]
    DifficultAlpineHiking
}