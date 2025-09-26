using System.Text.Json.Serialization;
using System.Collections.Generic;
using SharpValhalla.Enums;
using SharpValhalla.Interfaces;
using SharpValhalla.Models.Common;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Request;

/// <summary>
/// A request structure for calculating travel time and distance matrices between multiple locations.
/// Use MatrixRequest to compute one-to-many, many-to-one, or many-to-many matrices that provide
/// travel times and distances between locations. Useful for route optimization, delivery planning, location analysis, and travel time calculations.
/// </summary>
public class MatrixRequest {
    /// <summary>
    /// Array of source locations for the matrix calculation.
    /// </summary>
    [JsonPropertyName("sources")]
    public List<Location> Sources { get; set; }

    /// <summary>
    /// Array of target locations for the matrix calculation. If null, sources are used as targets.
    /// </summary>
    [JsonPropertyName("targets")]
    public List<Location>? Targets { get; set; }

    /// <summary>
    /// The costing model to use for route calculations.
    /// </summary>
    [JsonPropertyName("costing")]
    public CostingModel Costing { get; set; }

    /// <summary>
    /// Additional options specific to the chosen costing model.
    /// </summary>
    [JsonPropertyName("costing_options")]
    public CostingOptions? CostingOptions { get; set; }

    /// <summary>
    /// Distance units for the response output. Defaults to kilometers if null.
    /// </summary>
    [JsonPropertyName("units")]
    public Unit? Units { get; set; }

    /// <summary>
    /// Whether to return verbose output with additional information.
    /// </summary>
    [JsonPropertyName("verbose")]
    public bool? Verbose { get; set; }

    /// <summary>
    /// Maximum number of locations allowed in the matrix calculation.
    /// </summary>
    [JsonPropertyName("matrix_locations")]
    public int? MatrixLocations { get; set; }

    /// <summary>
    /// Coordinate encoding format for any returned route shapes.
    /// </summary>
    [JsonPropertyName("shape")]
    public ShapeFormat? Shape { get; set; }

    /// <summary>
    /// Filters to apply to the response attributes.
    /// </summary>
    [JsonPropertyName("filters")]
    public TraceAttributesFilter? Filters { get; set; }

    /// <summary>
    /// Whether to prioritize calculations by time or distance.
    /// </summary>
    [JsonPropertyName("prioritize_by")]
    public PriorityType? PrioritizeBy { get; set; }

    /// <summary>
    /// Indices of locations to exclude from the matrix calculation.
    /// </summary>
    [JsonPropertyName("exclude_locations")]
    public List<int>? ExcludeLocations { get; set; }

    /// <summary>
    /// Creates a matrix request with the specified parameters.
    /// </summary>
    public MatrixRequest(
        List<Location> sources,
        List<Location>? targets = null,
        CostingModel costing = CostingModel.Auto,
        CostingOptions? costingOptions = null,
        Unit? units = null,
        bool? verbose = null,
        int? matrixLocations = null,
        ShapeFormat? shape = null,
        TraceAttributesFilter? filters = null,
        PriorityType? prioritizeBy = null,
        List<int>? excludeLocations = null
    ) {
        Sources = sources;
        Targets = targets;
        Costing = costing;
        CostingOptions = costingOptions;
        Units = units;
        Verbose = verbose;
        MatrixLocations = matrixLocations;
        Shape = shape;
        Filters = filters;
        PrioritizeBy = prioritizeBy;
        ExcludeLocations = excludeLocations;
    }

    /// <summary>
    /// Creates a matrix request from objects conforming to ILocationProtocol.
    /// </summary>
    public MatrixRequest(
        IEnumerable<ILocation> sources,
        IEnumerable<ILocation>? targets = null,
        CostingModel costing = CostingModel.Auto,
        CostingOptions? costingOptions = null,
        Unit? units = null,
        bool? verbose = null,
        int? matrixLocations = null,
        ShapeFormat? shape = null,
        TraceAttributesFilter? filters = null,
        PriorityType? prioritizeBy = null,
        List<int>? excludeLocations = null
    ) {
        Sources = [];
        foreach (var s in sources)
            Sources.Add(new Location(s.Location.Latitude, s.Location.Longitude));
        Targets = targets != null ? [..targets.Select(t => new Location(t.Location.Latitude, t.Location.Longitude))] : null;
        Costing = costing;
        CostingOptions = costingOptions;
        Units = units;
        Verbose = verbose;
        MatrixLocations = matrixLocations;
        Shape = shape;
        Filters = filters;
        PrioritizeBy = prioritizeBy;
        ExcludeLocations = excludeLocations;
    }

    /// <summary>
    /// Creates a matrix request from arrays of coordinates.
    /// </summary>
    public MatrixRequest(
        IEnumerable<LocationCoordinate2D> sources,
        IEnumerable<LocationCoordinate2D>? targets = null,
        CostingModel costing = CostingModel.Auto,
        CostingOptions? costingOptions = null,
        Unit? units = null,
        bool? verbose = null,
        int? matrixLocations = null,
        ShapeFormat? shape = null,
        TraceAttributesFilter? filters = null,
        PriorityType? prioritizeBy = null,
        List<int>? excludeLocations = null
    ) {
        Sources          = new List<Location>(sources.Select(c => new Location(c.Latitude, c.Longitude)));
        Targets          = targets != null ? [..targets.Select(c => new Location(c.Latitude, c.Longitude))] : null;
        Costing          = costing;
        CostingOptions   = costingOptions;
        Units            = units;
        Verbose          = verbose;
        MatrixLocations  = matrixLocations;
        Shape            = shape;
        Filters          = filters;
        PrioritizeBy     = prioritizeBy;
        ExcludeLocations = excludeLocations;
    }
}