using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the different use types for edges or paths in Valhalla routing.
///
/// Each case corresponds to a specific way or connection type (e.g., road, ramp, ferry).
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum Use {
    /// <summary>Tram use type.</summary>
    [Description("tram")]
    Tram,
    /// <summary>Road use type.</summary>
    [Description("road")]
    Road,
    /// <summary>Ramp use type.</summary>
    [Description("ramp")]
    Ramp,
    /// <summary>Turn channel use type.</summary>
    [Description("turn_channel")]
    TurnChannel,
    /// <summary>Track use type.</summary>
    [Description("track")]
    Track,
    /// <summary>Driveway use type.</summary>
    [Description("driveway")]
    Driveway,
    /// <summary>Alley use type.</summary>
    [Description("alley")]
    Alley,
    /// <summary>Parking aisle use type.</summary>
    [Description("parking_aisle")]
    ParkingAisle,
    /// <summary>Emergency access use type.</summary>
    [Description("emergency_access")]
    EmergencyAccess,
    /// <summary>Drive-through use type.</summary>
    [Description("drive_through")]
    DriveThrough,
    /// <summary>Culdesac use type.</summary>
    [Description("culdesac")]
    Culdesac,
    /// <summary>Cycleway use type.</summary>
    [Description("cycleway")]
    Cycleway,
    /// <summary>Mountain bike use type.</summary>
    [Description("mountain_bike")]
    MountainBike,
    /// <summary>Sidewalk use type.</summary>
    [Description("sidewalk")]
    Sidewalk,
    /// <summary>Footway use type.</summary>
    [Description("footway")]
    Footway,
    /// <summary>Steps use type.</summary>
    [Description("steps")]
    Steps,
    /// <summary>Other use type.</summary>
    [Description("other")]
    Other,
    /// <summary>Rail ferry use type.</summary>
    [Description("rail-ferry")]
    RailFerry,
    /// <summary>Ferry use type.</summary>
    [Description("ferry")]
    Ferry,
    /// <summary>Rail use type.</summary>
    [Description("rail")]
    Rail,
    /// <summary>Bus use type.</summary>
    [Description("bus")]
    Bus,
    /// <summary>Egress connection use type.</summary>
    [Description("egress_connection")]
    EgressConnection,
    /// <summary>Platform connection use type.</summary>
    [Description("platform_connection")]
    PlatformConnection,
    /// <summary>Transit connection use type.</summary>
    [Description("transit_connection")]
    TransitConnection
}