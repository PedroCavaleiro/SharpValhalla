using System.Text.Json.Serialization;
using SharpValhalla.Enums;
using SharpValhalla.Models.Request;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Common;

/// <summary>
/// This class represents the shape to be sent to the MapMatching service.
/// </summary>
public class Location {
    [JsonPropertyName("lat")]
    public double? Latitude { get; set; }
    [JsonPropertyName("lon")]
    public double? Longitude { get; set; }
    [JsonPropertyName("date_time")]
    public string? Timestamp { get; set; }
    [JsonPropertyName("type")]
    public TraceType? TraceType { get; set; }
    [JsonPropertyName("heading")]
    public int? Heading { get; set; }
    [JsonPropertyName("heading_tolerance")]
    public int? HeadingTolerance { get; set; }
    [JsonPropertyName("street")]
    public int? Street { get; set; }
    [JsonPropertyName("way_id")]
    public int? WayId { get; set; }
    [JsonPropertyName("minimum_reachability")]
    public int? MinimumReachability { get; set; }
    [JsonPropertyName("radius")]
    public int? Radius { get; set; }
    [JsonPropertyName("rank_candidates")]
    public bool? RankCandidates { get; set; }
    [JsonPropertyName("preferred_side")]
    public PreferredSide? PreferredSide { get; set; }
    [JsonPropertyName("display_lat")]
    public double? DisplayLatitude { get; set; }
    [JsonPropertyName("display_lon")]
    public double? DisplayLongitude { get; set; }
    [JsonPropertyName("search_cutoff")]
    public int? SearchCutoff { get; set; }
    [JsonPropertyName("node_snap_tolerance")]
    public int? NodeSnapTolerance { get; set; }
    [JsonPropertyName("street_side_tolerance")]
    public int? StreetSideTolerance { get; set; }
    [JsonPropertyName("street_side_max_distance")]
    public int? StreetSideMaxDistance { get; set; }
    [JsonPropertyName("street_side_cutoff")]
    public RoadClass? StreetSideCutOff { get; set; }
    [JsonPropertyName("search_filter")]
    public SearchFilter? SearchFilter { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("city")]
    public string? City { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("postal_code")]
    public string? PostalCode { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    [JsonPropertyName("waiting")]
    public int? Waiting { get; set; }
    [JsonPropertyName("side_of_street")]
    public SideOfStreet? SideOfStreet { get; set; }
    [JsonPropertyName("original_index")]
    public int? OriginalIndex { get; set; }

    /// <summary>
    /// Main constructor for Location.
    /// </summary>
    public Location(
        double? latitude = null,
        double? longitude = null,
        string? timestamp = null,
        TraceType? traceType = null,
        int? heading = null,
        int? headingTolerance = null,
        int? street = null,
        int? wayId = null,
        int? minimumReachability = null,
        int? radius = null,
        bool? rankCandidates = null,
        PreferredSide? preferredSide = null,
        double? displayLatitude = null,
        double? displayLongitude = null,
        int? searchCutoff = null,
        int? nodeSnapTolerance = null,
        int? streetSideTolerance = null,
        int? streetSideMaxDistance = null,
        RoadClass? streetSideCutOff = null,
        SearchFilter? searchFilter = null,
        string? name = null,
        string? city = null,
        string? state = null,
        string? postalCode = null,
        string? country = null,
        string? phone = null,
        string? url = null,
        int? waiting = null,
        SideOfStreet? sideOfStreet = null,
        int? originalIndex = null
    ) {
        Latitude = latitude;
        Longitude = longitude;
        Timestamp = timestamp;
        TraceType = traceType;
        Heading = heading;
        HeadingTolerance = headingTolerance;
        Street = street;
        WayId = wayId;
        MinimumReachability = minimumReachability;
        Radius = radius;
        RankCandidates = rankCandidates;
        PreferredSide = preferredSide;
        DisplayLatitude = displayLatitude;
        DisplayLongitude = displayLongitude;
        SearchCutoff = searchCutoff;
        NodeSnapTolerance = nodeSnapTolerance;
        StreetSideTolerance = streetSideTolerance;
        StreetSideMaxDistance = streetSideMaxDistance;
        StreetSideCutOff = streetSideCutOff;
        SearchFilter = searchFilter;
        Name = name;
        City = city;
        State = state;
        PostalCode = postalCode;
        Country = country;
        Phone = phone;
        Url = url;
        Waiting = waiting;
        SideOfStreet = sideOfStreet;
        OriginalIndex = originalIndex;
    }

    /// <summary>
    /// Convenience constructor for response-only locations that might only have originalIndex.
    /// </summary>
    public Location(int originalIndex) {
        OriginalIndex = originalIndex;
    }
}