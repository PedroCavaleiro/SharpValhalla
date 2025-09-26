using System.Text.Json.Serialization;
// ReSharper disable ClassNeverInstantiated.Global

namespace SharpValhalla.Models.Response;

/// <summary>
/// Sign information attached to a maneuver, grouping different types of sign elements (exit number, branch, toward, name).
/// </summary>
public class SignResponse {
    /// <summary>
    /// Elements representing exit numbers.
    /// </summary>
    [JsonPropertyName("exit_number_elements")]
    public List<ManeuverSignElement>? ExitNumberElements { get; set; }

    /// <summary>
    /// Elements representing exit branches.
    /// </summary>
    [JsonPropertyName("exit_branch_elements")]
    public List<ManeuverSignElement>? ExitBranchElements { get; set; }

    /// <summary>
    /// Elements representing exit toward indicators.
    /// </summary>
    [JsonPropertyName("exit_toward_elements")]
    public List<ManeuverSignElement>? ExitTowardElements { get; set; }

    /// <summary>
    /// Elements representing exit names.
    /// </summary>
    [JsonPropertyName("exit_name_elements")]
    public List<ManeuverSignElement>? ExitNameElements { get; set; }
}

/// <summary>
/// An individual element of a maneuver sign (text and consecutive count).
/// </summary>
public abstract class ManeuverSignElement {
    /// <summary>
    /// The sign text.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Number of consecutive occurrences for the element.
    /// </summary>
    [JsonPropertyName("consecutive_count")]
    public int? ConsecutiveCount { get; set; }
}