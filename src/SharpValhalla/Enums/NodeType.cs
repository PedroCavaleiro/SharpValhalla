using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents different types of nodes in Valhalla routing.
///
/// Each case corresponds to a specific type of node or intersection.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum NodeType {
    /// <summary>Street intersection node.</summary>
    [Description("street_intersection")]
    StreetIntersection,
    /// <summary>Gate node.</summary>
    [Description("gate")]
    Gate,
    /// <summary>Bollard node.</summary>
    [Description("bollard")]
    Bollard,
    /// <summary>Toll booth node.</summary>
    [Description("toll_booth")]
    TollBooth,
    /// <summary>Multi-use transit stop node.</summary>
    [Description("multi_use_transit_stop")]
    MultiUseTransitStop,
    /// <summary>Bike share node.</summary>
    [Description("bike_share")]
    BikeShare,
    /// <summary>Parking node.</summary>
    [Description("parking")]
    Parking,
    /// <summary>Motorway junction node.</summary>
    [Description("motor_way_junction")]
    MotorWayJunction,
    /// <summary>Border control node.</summary>
    [Description("border_control")]
    BorderControl
}