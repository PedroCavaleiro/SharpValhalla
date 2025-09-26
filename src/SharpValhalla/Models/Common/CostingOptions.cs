using System.Text.Json.Serialization;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Common;

/// <summary>
/// Configuration options for route costing and avoidance preferences.
/// Use CostingOptions to specify routing preferences such as avoiding tolls, highways, or ferries,
/// and to control various routing parameters including vehicle specifications, road preferences, and cost factors.
/// All properties are optional, allowing you to specify only the preferences you need.
/// Different costing models support different subsets of these options.
/// </summary>
public class CostingOptions {
    // Avoidance Options
    [JsonPropertyName("avoid_tolls")]
    public bool? AvoidTolls { get; set; }
    [JsonPropertyName("avoid_highways")]
    public bool? AvoidHighways { get; set; }
    [JsonPropertyName("avoid_ferries")]
    public bool? AvoidFerries { get; set; }
    [JsonPropertyName("shortest")]
    public bool? Shortcut { get; set; }

    // Maneuver and Turn Options
    [JsonPropertyName("maneuver_penalty")]
    public double? ManeuverPenalty { get; set; }
    [JsonPropertyName("gate_cost")]
    public double? GateCost { get; set; }
    [JsonPropertyName("gate_access_cost")]
    public double? GateAccessCost { get; set; }
    [JsonPropertyName("toll_booth_cost")]
    public double? TollBoothCost { get; set; }
    [JsonPropertyName("toll_booth_access_cost")]
    public double? TollBoothAccessCost { get; set; }
    [JsonPropertyName("country_changing_penalty")]
    public double? CountryChangingPenalty { get; set; }

    // Vehicle Specifications (Auto/Truck)
    [JsonPropertyName("length")]
    public double? Length { get; set; }
    [JsonPropertyName("width")]
    public double? Width { get; set; }
    [JsonPropertyName("height")]
    public double? Height { get; set; }
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
    [JsonPropertyName("axle_load")]
    public double? AxleLoad { get; set; }
    [JsonPropertyName("axle_count")]
    public int? AxleCount { get; set; }
    [JsonPropertyName("hazmat")]
    public bool? Hazmat { get; set; }

    // Road Type Preferences
    [JsonPropertyName("motorway_factor")]
    public double? MotorwayFactor { get; set; }
    [JsonPropertyName("trunk_factor")]
    public double? TrunkFactor { get; set; }
    [JsonPropertyName("primary_factor")]
    public double? PrimaryFactor { get; set; }
    [JsonPropertyName("secondary_factor")]
    public double? SecondaryFactor { get; set; }
    [JsonPropertyName("tertiary_factor")]
    public double? TertiaryFactor { get; set; }
    [JsonPropertyName("unclassified_factor")]
    public double? UnclassifiedFactor { get; set; }
    [JsonPropertyName("residential_factor")]
    public double? ResidentialFactor { get; set; }
    [JsonPropertyName("service_road_factor")]
    public double? ServiceRoadFactor { get; set; }

    // Speed and Time Factors
    [JsonPropertyName("top_speed")]
    public double? TopSpeed { get; set; }
    [JsonPropertyName("speed_factor")]
    public double? SpeedFactor { get; set; }
    [JsonPropertyName("uturn_penalty")]
    public double? UturnPenalty { get; set; }
    [JsonPropertyName("use_traffic")]
    public bool? UseTraffic { get; set; }

    // Walking/Pedestrian Options
    [JsonPropertyName("walking_speed")]
    public double? WalkingSpeed { get; set; }
    [JsonPropertyName("walkway_factor")]
    public double? WalkwayFactor { get; set; }
    [JsonPropertyName("sidewalk_factor")]
    public double? SidewalkFactor { get; set; }
    [JsonPropertyName("alley_factor")]
    public double? AlleyFactor { get; set; }
    [JsonPropertyName("driveway_factor")]
    public double? DrivewayFactor { get; set; }
    [JsonPropertyName("crossing_penalty")]
    public double? CrossingPenalty { get; set; }
    [JsonPropertyName("max_grade")]
    public double? MaxGrade { get; set; }

    // Bicycle Options
    [JsonPropertyName("cycling_speed")]
    public double? CyclingSpeed { get; set; }
    [JsonPropertyName("bicycle_lane_factor")]
    public double? BicycleLaneFactor { get; set; }
    [JsonPropertyName("cycleway_factor")]
    public double? CyclewayFactor { get; set; }
    [JsonPropertyName("mountain_bike_factor")]
    public double? MountainBikeFactor { get; set; }
    [JsonPropertyName("avoid_bad_surfaces")]
    public bool? AvoidBadSurfaces { get; set; }

    // Transit Options
    [JsonPropertyName("transit_mode_filters")]
    public Dictionary<string, object>? TransitModeFilters { get; set; }
    [JsonPropertyName("transit_walking_distance")]
    public double? TransitWalkingDistance { get; set; }

    /// <summary>
    /// Creates a new costing options configuration.
    /// </summary>
    public CostingOptions(
        bool? avoidTolls = null,
        bool? avoidHighways = null,
        bool? avoidFerries = null,
        bool? shortcut = null,
        double? maneuverPenalty = null,
        double? gateCost = null,
        double? gateAccessCost = null,
        double? tollBoothCost = null,
        double? tollBoothAccessCost = null,
        double? countryChangingPenalty = null,
        double? length = null,
        double? width = null,
        double? height = null,
        double? weight = null,
        double? axleLoad = null,
        int? axleCount = null,
        bool? hazmat = null,
        double? motorwayFactor = null,
        double? trunkFactor = null,
        double? primaryFactor = null,
        double? secondaryFactor = null,
        double? tertiaryFactor = null,
        double? unclassifiedFactor = null,
        double? residentialFactor = null,
        double? serviceRoadFactor = null,
        double? topSpeed = null,
        double? speedFactor = null,
        double? uturnPenalty = null,
        bool? useTraffic = null,
        double? walkingSpeed = null,
        double? walkwayFactor = null,
        double? sidewalkFactor = null,
        double? alleyFactor = null,
        double? drivewayFactor = null,
        double? crossingPenalty = null,
        double? maxGrade = null,
        double? cyclingSpeed = null,
        double? bicycleLaneFactor = null,
        double? cyclewayFactor = null,
        double? mountainBikeFactor = null,
        bool? avoidBadSurfaces = null,
        Dictionary<string, object>? transitModeFilters = null,
        double? transitWalkingDistance = null
    ) {
        AvoidTolls = avoidTolls;
        AvoidHighways = avoidHighways;
        AvoidFerries = avoidFerries;
        Shortcut = shortcut;
        ManeuverPenalty = maneuverPenalty;
        GateCost = gateCost;
        GateAccessCost = gateAccessCost;
        TollBoothCost = tollBoothCost;
        TollBoothAccessCost = tollBoothAccessCost;
        CountryChangingPenalty = countryChangingPenalty;
        Length = length;
        Width = width;
        Height = height;
        Weight = weight;
        AxleLoad = axleLoad;
        AxleCount = axleCount;
        Hazmat = hazmat;
        MotorwayFactor = motorwayFactor;
        TrunkFactor = trunkFactor;
        PrimaryFactor = primaryFactor;
        SecondaryFactor = secondaryFactor;
        TertiaryFactor = tertiaryFactor;
        UnclassifiedFactor = unclassifiedFactor;
        ResidentialFactor = residentialFactor;
        ServiceRoadFactor = serviceRoadFactor;
        TopSpeed = topSpeed;
        SpeedFactor = speedFactor;
        UturnPenalty = uturnPenalty;
        UseTraffic = useTraffic;
        WalkingSpeed = walkingSpeed;
        WalkwayFactor = walkwayFactor;
        SidewalkFactor = sidewalkFactor;
        AlleyFactor = alleyFactor;
        DrivewayFactor = drivewayFactor;
        CrossingPenalty = crossingPenalty;
        MaxGrade = maxGrade;
        CyclingSpeed = cyclingSpeed;
        BicycleLaneFactor = bicycleLaneFactor;
        CyclewayFactor = cyclewayFactor;
        MountainBikeFactor = mountainBikeFactor;
        AvoidBadSurfaces = avoidBadSurfaces;
        TransitModeFilters = transitModeFilters;
        TransitWalkingDistance = transitWalkingDistance;
    }
}