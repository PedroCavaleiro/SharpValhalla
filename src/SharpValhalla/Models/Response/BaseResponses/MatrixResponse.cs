using System.Text.Json.Serialization;
using SharpValhalla.Enums;
using SharpValhalla.Models.Common;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Response.BaseResponses;

/// <summary>
/// Represents the response from the Valhalla Matrix API.
/// The matrix service computes time and distance between many origins and destinations,
/// returning the results in matrix format. The response includes source and target
/// locations along with the computed matrices.
/// </summary>
public class MatrixResponse {
    /// <summary>
    /// Array of source locations used in the matrix computation.
    /// </summary>
    [JsonPropertyName("sources")]
    public List<Location> Sources { get; set; }

    /// <summary>
    /// Array of target locations used in the matrix computation.
    /// </summary>
    [JsonPropertyName("targets")]
    public List<Location> Targets { get; set; }

    /// <summary>
    /// Matrix of results from sources to targets.
    /// A two-dimensional array where sourcesToTargets[i][j] represents the result from source i to target j.
    /// Each element contains travel time and distance information, or null if no route could be found.
    /// </summary>
    [JsonPropertyName("sources_to_targets")]
    public List<List<MatrixElement?>> SourcesToTargets { get; set; }

    /// <summary>
    /// Optional matrix of results from targets to sources.
    /// Only present if bidirectional=true was specified in the request.
    /// </summary>
    [JsonPropertyName("targets_to_sources")]
    public List<List<MatrixElement?>>? TargetsToSources { get; set; }

    /// <summary>
    /// The distance units used in the response.
    /// Possible values: "kilometers", "miles"
    /// </summary>
    [JsonPropertyName("units")]
    public Unit Units { get; set; }

    /// <summary>
    /// Optional encoded polyline shape.
    /// Only present when shape output was requested in the original request.
    /// </summary>
    [JsonPropertyName("shape")]
    public string? Shape { get; set; }

    /// <summary>
    /// Optional array of warning messages.
    /// Contains any warnings generated during the matrix computation process.
    /// </summary>
    [JsonPropertyName("warnings")]
    public List<string>? Warnings { get; set; }

    /// <summary>
    /// Optional request identifier for tracking purposes.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Creates a new matrix response.
    /// </summary>
    public MatrixResponse(
        List<Location>              sources,
        List<Location>              targets,
        List<List<MatrixElement?>>  sourcesToTargets,
        List<List<MatrixElement?>>? targetsToSources = null,
        Unit                        units            = Unit.Kilometers,
        string?                     shape            = null,
        List<string>?               warnings         = null,
        string?                     id               = null
    ) {
        Sources = sources;
        Targets = targets;
        SourcesToTargets = sourcesToTargets;
        TargetsToSources = targetsToSources;
        Units = units;
        Shape = shape;
        Warnings = warnings;
        Id = id;
    }
}