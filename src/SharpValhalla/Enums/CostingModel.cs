using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Run-time costing model for route path generation.
/// </summary>
public enum CostingModel {
    /// <summary>
    /// Standard costing for driving routes by car, motorcycle, truck, and so on that obeys automobile driving rules, such as access and turn restrictions. Auto provides a short time path (though not guaranteed to be shortest time) and uses intersection costing to minimize turns and maneuvers or road name changes. Routes also tend to favor highways and higher classification roads, such as motorways and trunks.
    /// </summary>
    [Description("auto")]
    Auto,
    /// <summary>
    /// Standard costing for travel by bicycle, with a slight preference for using cycleways or roads with bicycle lanes. Bicycle routes follow regular roads when needed, but avoid roads without bicycle access.
    /// </summary>
    [Description("bicycle")]
    Bicycle,
    /// <summary>
    /// Standard walking route that excludes roads without pedestrian access. In general, pedestrian routes are shortest distance with the following exceptions: walkways and footpaths are slightly favored, while steps or stairs and alleys are slightly avoided.
    /// </summary>
    [Description("pedestrian")]
    Pedestrian,
    /// <summary>
    /// Standard costing for bus routes. Bus costing inherits the auto costing behaviors, but checks for bus access on the roads.
    /// </summary>
    [Description("bus")]
    Bus,
    /// <summary>
    /// A combination of pedestrian and bicycle. Use bike share station(amenity:bicycle_rental) to change the travel mode
    /// Note: This model is still in BETA
    /// </summary>
    [Description("bikeshare")]
    Bikeshare,
    /// <summary>
    /// Standard costing for trucks. Truck costing inherits the auto costing behaviors, but checks for truck access, width and height restrictions, and weight limits on the roads.
    /// </summary>
    [Description("truck")]
    Truck,
    /// <summary>
    /// Deprecated. Use Auto instead.
    /// </summary>
    [Description("hov")]
    Hov,
    /// <summary>
    /// Standard costing for taxi routes. Taxi costing inherits the auto costing behaviors, but checks for taxi lane access on the roads and favors those roads.
    /// </summary>
    [Description("taxi")]
    Taxi,
    /// <summary>
    /// Standard costing for travel by motor scooter or moped. By default, motor_scooter costing will avoid higher class roads unless the country overrides allows motor scooters on these roads. Motor scooter routes follow regular roads when needed, but avoid roads without motor_scooter, moped, or mofa access.
    /// </summary>
    [Description("motor_scooter")]
    MotorScooter,
    /// <summary>
    /// Standard costing for travel by motorcycle. This costing model provides options to tune the route to take roadways (road touring) vs. tracks and trails (adventure motorcycling).
    /// Note: This model is still in BETA
    /// </summary>
    [Description("motorcycle")]
    Motorcycle,
    /// <summary>
    /// Currently supports pedestrian and transit. In the future, multimodal will support a combination of all of the above.
    /// </summary>
    [Description("multi_modal")]
    MultiModal
}