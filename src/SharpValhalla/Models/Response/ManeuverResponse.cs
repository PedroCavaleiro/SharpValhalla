using System.Text.Json.Serialization;
using SharpValhalla.Enums;

// ReSharper disable ClassNeverInstantiated.Global

namespace SharpValhalla.Models.Response;

/// <summary>
/// A single maneuver within a leg describing an instruction, timing,
/// geometry indices, and other metadata used for routing and navigation.
/// </summary>
public class ManeuverResponse {
    [JsonPropertyName("type")]
    public int Type { get; set; }
    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }
    [JsonPropertyName("verbal_succinct_transition_instruction")]
    public string? VerbalSuccinctTransitionInstruction { get; set; }
    [JsonPropertyName("verbal_pre_transition_instruction")]
    public string? VerbalPreTransitionInstruction { get; set; }
    [JsonPropertyName("verbal_post_transition_instruction")]
    public string? VerbalPostTransitionInstruction { get; set; }
    [JsonPropertyName("verbal_transition_alert_instruction")]
    public string? VerbalTransitionAlertInstruction { get; set; }
    [JsonPropertyName("street_names")]
    public List<string>? StreetNames { get; set; }
    [JsonPropertyName("time")]
    public double Time { get; set; }
    [JsonPropertyName("length")]
    public double Length { get; set; }
    [JsonPropertyName("cost")]
    public double Cost { get; set; }
    [JsonPropertyName("begin_shape_index")]
    public int BeginShapeIndex { get; set; }
    [JsonPropertyName("end_shape_index")]
    public int EndShapeIndex { get; set; }
    [JsonPropertyName("verbal_multi_cue")]
    public bool VerbalMultiCue { get; set; }
    [JsonPropertyName("travel_mode")]
    public TravelMode TravelMode { get; set; }
    [JsonPropertyName("travel_type")]
    public TravelType? TravelType { get; set; }
    [JsonPropertyName("begin_street_names")]
    public List<string>? BeginStreetNames { get; set; }
    [JsonPropertyName("toll")]
    public bool Toll { get; set; }
    [JsonPropertyName("highway")]
    public bool Highway { get; set; }
    [JsonPropertyName("ferry")]
    public bool Ferry { get; set; }
    [JsonPropertyName("sign")]
    public SignResponse? Sign { get; set; }
    [JsonPropertyName("roundabout_exit_count")]
    public int? RoundaboutExitCount { get; set; }
    [JsonPropertyName("depart_instruction")]
    public string? DepartInstruction { get; set; }
    [JsonPropertyName("verbal_depart_instruction")]
    public string? VerbalDepartInstruction { get; set; }
    [JsonPropertyName("arrive_instruction")]
    public string? ArriveInstruction { get; set; }
    [JsonPropertyName("verbal_arrive_instruction")]
    public string? VerbalArriveInstruction { get; set; }
    [JsonPropertyName("transit_info")]
    public TransitInfo? TransitInfo { get; set; }
    [JsonPropertyName("bearing_before")]
    public int? BearingBefore { get; set; }
    [JsonPropertyName("bearing_after")]
    public int? BearingAfter { get; set; }
    [JsonPropertyName("lanes")]
    public List<Lane>? Lanes { get; set; }
}