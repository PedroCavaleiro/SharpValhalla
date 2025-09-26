using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Classification of roads by importance or hierarchy used in routing.
/// </summary>
public enum RoadClass {
    /// <summary>Motorway road class.</summary>
    [Description("motorway")]
    Motorway,
    /// <summary>Trunk road class.</summary>
    [Description("trunk")]
    Trunk,
    /// <summary>Primary road class.</summary>
    [Description("primary")]
    Primary,
    /// <summary>Secondary road class.</summary>
    [Description("secondary")]
    Secondary,
    /// <summary>Tertiary road class.</summary>
    [Description("tertiary")]
    Tertiary,
    /// <summary>Unclassified road class.</summary>
    [Description("unclassified")]
    Unclassified,
    /// <summary>Residential road class.</summary>
    [Description("residential")]
    Residential,
    /// <summary>Service or other road class.</summary>
    [Description("service_other")]
    ServiceOther
}