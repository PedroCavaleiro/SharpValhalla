namespace SharpValhalla.Enums;

/// <summary>
/// Represents the kind of transit stop: a simple stop or a station.
/// </summary>
public enum TransitStopType {
    /// <summary>
    /// A simple stop (e.g., a single platform or stop sign).
    /// </summary>
    SimpleStop = 0,
    /// <summary>
    /// A station with multiple platforms or facilities.
    /// </summary>
    Station = 1
}