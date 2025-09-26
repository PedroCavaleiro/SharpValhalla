using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents all available filter keys that can be applied when working with
/// Valhalla routing and map-matching data.
///
/// Each case corresponds to a specific field in the Valhalla API, grouped by
/// category (edge, node, admin, matched, etc.).
/// The raw value matches the exact key string expected by Valhalla.
/// </summary>
public enum Filter {
    /// <summary>List of names</summary>
    [Description("edge.names")]
    EdgeNames,
    /// <summary>The matched edge length in the units specified (default is kilometers). If source_percent_along and/or target_percent_along are present, this represents the partially matched edge length, otherwise the full edge length.</summary>
    [Description("edge.length")]
    EdgeLength,
    /// <summary>Edge speed in the units specified. The default is kilometers per hour.</summary>
    [Description("edge.speed")]
    EdgeSpeed,
    /// <summary>Contains all flow speeds available for that edge in the units specified (default is kilometers per hour). Note: These speeds are faded with the current flow (if available). The current_flow fades with the flow_mask that was passed to the request.</summary>
    [Description("edge.speeds_faded")]
    EdgeSpeedsFaded,
    /// <summary>Contains all raw flow speeds available for that edge in the units specified (default is kilometers per hour).</summary>
    [Description("edge.speeds_non_faded")]
    EdgeSpeedsNonFaded,
    /// <summary>Road class values</summary>
    [Description("edge.road_class")]
    EdgeRoadClass,
    /// <summary>The direction at the beginning of an edge. The units are degrees from north in a clockwise direction.</summary>
    [Description("edge.begin_heading")]
    EdgeBeginHeading,
    /// <summary>The direction at the end of an edge. The units are degrees from north in a clockwise direction.</summary>
    [Description("edge.end_heading")]
    EdgeEndHeading,
    /// <summary>Index into the list of shape points for the start of the edge.</summary>
    [Description("edge.begin_shape_index")]
    EdgeBeginShapeIndex,
    /// <summary>Index into the list of shape points for the end of the edge.</summary>
    [Description("edge.end_shape_index")]
    EdgeEndShapeIndex,
    /// <summary>Traversability values, if available</summary>
    [Description("edge.traversability")]
    EdgeTraversability,
    /// <summary>Use values</summary>
    [Description("edge.use")]
    EdgeUse,
    /// <summary>If the edge has any toll.</summary>
    [Description("edge.toll")]
    EdgeToll,
    /// <summary>If the edge is unpaved or rough pavement.</summary>
    [Description("edge.unpaved")]
    EdgeUnpaved,
    /// <summary>If the edge is a tunnel.</summary>
    [Description("edge.tunnel")]
    EdgeTunnel,
    /// <summary>If the edge is a bridge.</summary>
    [Description("edge.bridge")]
    EdgeBridge,
    /// <summary>If the edge is a roundabout.</summary>
    [Description("edge.roundabout")]
    EdgeRoundabout,
    /// <summary>If the edge is an internal intersection.</summary>
    [Description("edge.internal_intersection")]
    EdgeInternalIntersection,
    /// <summary>If the flag is enabled for driving on the right side of the street.</summary>
    [Description("edge.drive_on_right")]
    EdgeDriveOnRight,
    /// <summary>Surface values</summary>
    [Description("edge.surface")]
    EdgeSurface,
    /// <summary>List of exit number elements. If an exit number element exists, it is typically just one value. Element example: 91B</summary>
    [Description("edge.sign.exit_number")]
    EdgeSignExitNumber,
    /// <summary>List of exit branch elements. An exit branch element is the subsequent road name or route number after the sign. Element example: I 95 North</summary>
    [Description("edge.sign.exit_branch")]
    EdgeSignExitBranch,
    /// <summary>List of exit toward elements. The exit toward element is the location where the road ahead goes; the location is typically a control city, but may also be a future road name or route number. Element example: New York</summary>
    [Description("edge.sign.exit_toward")]
    EdgeSignExitToward,
    /// <summary>List of exit name elements. The exit name element is the interchange identifier, although typically not used in the United States. Element example: Gettysburg Pike</summary>
    [Description("edge.sign.exit_name")]
    EdgeSignExitName,
    /// <summary>Travel mode values</summary>
    [Description("edge.travel_mode")]
    EdgeTravelMode,
    /// <summary>Vehicle type values</summary>
    [Description("edge.vehicle_type")]
    EdgeVehicleType,
    /// <summary>Pedestrian type values</summary>
    [Description("edge.pedestrian_type")]
    EdgePedestrianType,
    /// <summary>Bicycle type values</summary>
    [Description("edge.bicycle_type")]
    EdgeBicycleType,
    /// <summary>Transit type values</summary>
    [Description("edge.transit_type")]
    EdgeTransitType,
    /// <summary>Identifier of an edge within the tiled, hierarchical graph.</summary>
    [Description("edge.id")]
    EdgeId,
    /// <summary>Whether or not the edge is inside of a building or structure or not.</summary>
    [Description("edge.indoor")]
    EdgeIndoor,
    /// <summary>Way identifier of the OpenStreetMap base data.</summary>
    [Description("edge.way_id")]
    EdgeWayId,
    /// <summary>The weighted grade factor. Valhalla manufactures a weighted_grade from elevation data. It is a measure used for hill avoidance in routing - sort of a relative energy use along an edge. But since an edge in Valhalla can possibly go up and down over several hills it might not equate to what most folks think of as grade.</summary>
    [Description("edge.weighted_grade")]
    EdgeWeightedGrade,
    /// <summary>The maximum upward slope. A value of 32768 indicates no elevation data is available for this edge.</summary>
    [Description("edge.max_upward_grade")]
    EdgeMaxUpwardGrade,
    /// <summary>The maximum downward slope. A value of 32768 indicates no elevation data is available for this edge.</summary>
    [Description("edge.max_downward_grade")]
    EdgeMaxDownwardGrade,
    /// <summary>The mean or average elevation along the edge. Units are meters by default. If the units are specified as miles, then the mean elevation is returned in feet. A value of 32768 indicates no elevation data is available for this edge.</summary>
    [Description("edge.mean_elevation")]
    EdgeMeanElevation,
    /// <summary>The number of lanes for this edge.</summary>
    [Description("edge.lane_count")]
    EdgeLaneCount,
    /// <summary>The type (if any) of bicycle lane along this edge.</summary>
    [Description("edge.cycle_lane")]
    EdgeCycleLane,
    /// <summary>The bike network for this edge.</summary>
    [Description("edge.bicycle_network")]
    EdgeBicycleNetwork,
    /// <summary>Classification of hiking trails based on difficulty.</summary>
    [Description("edge.sac_scale")]
    EdgeSacScale,
    /// <summary>If the edge has a shoulder.</summary>
    [Description("edge.shoulder")]
    EdgeShoulder,
    /// <summary>Sidewalk values</summary>
    [Description("edge.sidewalk")]
    EdgeSidewalk,
    /// <summary>The relative density along the edge.</summary>
    [Description("edge.density")]
    EdgeDensity,
    /// <summary>Edge speed limit in the units specified. The default is kilometers per hour.</summary>
    [Description("edge.speed_limit")]
    EdgeSpeedLimit,
    /// <summary>Edge truck speed in the units specified. The default is kilometers per hour.</summary>
    [Description("edge.truck_speed")]
    EdgeTruckSpeed,
    /// <summary>If edge is part of a truck network/route.</summary>
    [Description("edge.truck_route")]
    EdgeTruckRoute,
    /// <summary>If the edge is a country crossing.</summary>
    [Description("edge.country_crossing")]
    EdgeCountryCrossing,
    /// <summary>True if the edge is traversed forwards and False if it is traversed backwards with respect to the reference shape/geometry (ie. the direction in which it was digitized).</summary>
    [Description("edge.forward")]
    EdgeForward,
    /// <summary>If the edge contains a traffic signal in its direction.</summary>
    [Description("edge.traffic_signal")]
    EdgeTrafficSignal,
    /// <summary>The direction at the beginning of this intersecting edge. The units are degrees from north in a clockwise direction.</summary>
    [Description("node.intersecting_edge.begin_heading")]
    NodeIntersectingEdgeBeginHeading,
    /// <summary>If this intersecting edge at the end node has consistent names with the path from edge.</summary>
    [Description("node.intersecting_edge.from_edge_name_consistency")]
    NodeIntersectingEdgeFromEdgeNameConsistency,
    /// <summary>If this intersecting edge at the end node has consistent names with the path to edge.</summary>
    [Description("node.intersecting_edge.to_edge_name_consistency")]
    NodeIntersectingEdgeToEdgeNameConsistency,
    /// <summary>Driveability values, if available</summary>
    [Description("node.intersecting_edge.driveability")]
    NodeIntersectingEdgeDriveability,
    /// <summary>Cyclability values, if available</summary>
    [Description("node.intersecting_edge.cyclability")]
    NodeIntersectingEdgeCyclability,
    /// <summary>Walkability values, if available</summary>
    [Description("node.intersecting_edge.walkability")]
    NodeIntersectingEdgeWalkability,
    /// <summary>Use values</summary>
    [Description("node.intersecting_edge.use")]
    NodeIntersectingEdgeUse,
    /// <summary>Road class values</summary>
    [Description("node.intersecting_edge.road_class")]
    NodeIntersectingEdgeRoadClass,
    /// <summary>The number of lanes for this edge.</summary>
    [Description("node.intersecting_edge.lane_count")]
    NodeIntersectingEdgeLaneCount,
    /// <summary>Elapsed time of the path to arrive at this node.</summary>
    [Description("node.elapsed_time")]
    NodeElapsedTime,
    /// <summary>Index value in the admin list.</summary>
    [Description("node.admin_index")]
    NodeAdminIndex,
    /// <summary>Node type values</summary>
    [Description("node.type")]
    NodeType,
    /// <summary>A boolean value indicating whether the node is a traffic signal (true or false)</summary>
    [Description("node.traffic_signal")]
    NodeTrafficSignal,
    /// <summary>If this node is a fork.</summary>
    [Description("node.fork")]
    NodeFork,
    /// <summary>Time zone string for this node.</summary>
    [Description("node.time_zone")]
    NodeTimeZone,
    /// <summary>OSM changeset</summary>
    [Description("osm_changeset")]
    OsmChangeset,
    /// <summary>The encoded polyline of the matched path.</summary>
    [Description("shape")]
    Shape,
    /// <summary>Country ISO 3166-1 alpha-2 code.</summary>
    [Description("admin.country_code")]
    AdminCountryCode,
    /// <summary>Country name.</summary>
    [Description("admin.country_text")]
    AdminCountryText,
    /// <summary>State code.</summary>
    [Description("admin.state_code")]
    AdminStateCode,
    /// <summary>State name.</summary>
    [Description("admin.state_text")]
    AdminStateText,
    /// <summary>List of match results when using the map_snap shape match algorithm. There is a one-to-one correspondence with the input set of latitude, longitude coordinates and this list of match results.</summary>
    [Description("matched.point")]
    MatchedPoint,
    /// <summary>Describes the type of this match result - possible values include:</summary>
    [Description("matched.type")]
    MatchedType,
    /// <summary>The index of the edge in the list of edges that this matched point is associated with. This value will not exist if this point was unmatched.</summary>
    [Description("matched.edge_index")]
    MatchedEdgeIndex,
    /// <summary>The boolean value is true if this match result is the begin location of a route disconnect. This value will not exist if this is false.</summary>
    [Description("matched.begin_route_discontinuity")]
    MatchedBeginRouteDiscontinuity,
    /// <summary>The boolean value is true if this match result is the end location of a route disconnect. This value will not exist if this is false.</summary>
    [Description("matched.end_route_discontinuity")]
    MatchedEndRouteDiscontinuity,
    /// <summary>The distance along the associated edge for this matched point. For example, if the matched point is halfway along the edge then the value would be 0.5. This value will not exist if this point was unmatched.</summary>
    [Description("matched.distance_along_edge")]
    MatchedDistanceAlongEdge,
    /// <summary>The distance in meters from the trace point to the matched point. This value will not exist if this point was unmatched.</summary>
    [Description("matched.distance_from_trace_point")]
    MatchedDistanceFromTracePoint
}