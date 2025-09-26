using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the different vehicle types for edges in Valhalla routing.
///
/// Each case corresponds to a specific type of motorized vehicle.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum VehicleType {
    /// <summary>Car vehicle type.</summary>
    [Description("car")]
    Car,
    /// <summary>Motorcycle vehicle type.</summary>
    [Description("motorcycle")]
    Motorcycle,
    /// <summary>Bus vehicle type.</summary>
    [Description("bus")]
    Bus,
    /// <summary>Tractor trailer vehicle type.</summary>
    [Description("tractor_trailer")]
    TractorTrailer
}