namespace SharpValhalla.Enums;

/// <summary>
/// Represents different types of navigation maneuvers.
/// </summary>
public enum ManeuverType {
    /// <summary>None</summary>
    None = 0,
    /// <summary>Start</summary>
    Start = 1,
    /// <summary>Start right</summary>
    StartRight = 2,
    /// <summary>Start left</summary>
    StartLeft = 3,
    /// <summary>Destination</summary>
    Destination = 4,
    /// <summary>Destination right</summary>
    DestinationRight = 5,
    /// <summary>Destination left</summary>
    DestinationLeft = 6,
    /// <summary>Becomes</summary>
    Becomes = 7,
    /// <summary>Continue</summary>
    Continue = 8,
    /// <summary>Slight right</summary>
    SlightRight = 9,
    /// <summary>Right</summary>
    Right = 10,
    /// <summary>Sharp right</summary>
    SharpRight = 11,
    /// <summary>U-turn right</summary>
    UturnRight = 12,
    /// <summary>U-turn left</summary>
    UturnLeft = 13,
    /// <summary>Sharp left</summary>
    SharpLeft = 14,
    /// <summary>Left</summary>
    Left = 15,
    /// <summary>Slight left</summary>
    SlightLeft = 16,
    /// <summary>Ramp straight</summary>
    RampStraight = 17,
    /// <summary>Ramp right</summary>
    RampRight = 18,
    /// <summary>Ramp left</summary>
    RampLeft = 19,
    /// <summary>Exit right</summary>
    ExitRight = 20,
    /// <summary>Exit left</summary>
    ExitLeft = 21,
    /// <summary>Stay straight</summary>
    StayStraight = 22,
    /// <summary>Stay right</summary>
    StayRight = 23,
    /// <summary>Stay left</summary>
    StayLeft = 24,
    /// <summary>Merge</summary>
    Merge = 25,
    /// <summary>Roundabout enter</summary>
    RoundaboutEnter = 26,
    /// <summary>Roundabout exit</summary>
    RoundaboutExit = 27,
    /// <summary>Ferry enter</summary>
    FerryEnter = 28,
    /// <summary>Ferry exit</summary>
    FerryExit = 29,
    /// <summary>Transit</summary>
    Transit = 30,
    /// <summary>Transit transfer</summary>
    TransitTransfer = 31,
    /// <summary>Transit remain on</summary>
    TransitRemainOn = 32,
    /// <summary>Transit connection start</summary>
    TransitConnectionStart = 33,
    /// <summary>Transit connection transfer</summary>
    TransitConnectionTransfer = 34,
    /// <summary>Transit connection destination</summary>
    TransitConnectionDestination = 35,
    /// <summary>Post transit connection destination</summary>
    PostTransitConnectionDestination = 36,
    /// <summary>Merge right</summary>
    MergeRight = 37,
    /// <summary>Merge left</summary>
    MergeLeft = 38,
    /// <summary>Elevator enter</summary>
    ElevatorEnter = 39,
    /// <summary>Steps enter</summary>
    StepsEnter = 40,
    /// <summary>Escalator enter</summary>
    EscalatorEnter = 41,
    /// <summary>Building enter</summary>
    BuildingEnter = 42,
    /// <summary>Building exit</summary>
    BuildingExit = 43
}