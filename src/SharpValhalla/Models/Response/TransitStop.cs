using System.Text.Json.Serialization;
using SharpValhalla.Enums;

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Response;

/// <summary>
/// Information about a transit stop including type, times, and location.
/// </summary>
public class TransitStop {
    /// <summary>
    /// The transit stop type.
    /// </summary>
    [JsonPropertyName("type")]
    public TransitStopType Type { get; set; }

    /// <summary>
    /// The stop name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Scheduled or actual arrival time as a string.
    /// </summary>
    [JsonPropertyName("arrival_time")]
    public string ArrivalDateTime { get; set; } = string.Empty;

    /// <summary>
    /// Scheduled or actual departure time as a string.
    /// </summary>
    [JsonPropertyName("departure_time")]
    public string DepartureDateTime { get; set; } = string.Empty;

    /// <summary>
    /// Whether the times are assumed from schedule.
    /// </summary>
    [JsonPropertyName("assumed_schedule")]
    public bool AssumedSchedule { get; set; }

    /// <summary>
    /// Latitude of the stop.
    /// </summary>
    [JsonPropertyName("lat")]
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude of the stop.
    /// </summary>
    [JsonPropertyName("lon")]
    public double Longitude { get; set; }

    /// <summary>
    /// Default constructor for deserialization.
    /// </summary>
    public TransitStop() {}

    /// <summary>
    /// Constructor for all properties.
    /// </summary>
    public TransitStop(
        TransitStopType type, 
        string          name, 
        string          arrivalDateTime, 
        string          departureDateTime, 
        bool            assumedSchedule, 
        double          latitude, 
        double          longitude
    ) {
        Type              = type;
        Name              = name;
        ArrivalDateTime   = arrivalDateTime;
        DepartureDateTime = departureDateTime;
        AssumedSchedule   = assumedSchedule;
        Latitude          = latitude;
        Longitude         = longitude;
    }
}