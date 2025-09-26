using System.Text.Json.Serialization;
using SharpValhalla.Enums;
using SharpValhalla.Extensions;
using Action = SharpValhalla.Enums.Action;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace SharpValhalla.Models.Request;

/// <summary>
/// The structure that represents the trace attributes filters.
/// </summary>
public class TraceAttributesFilter {
    /// <summary>
    /// Sets the filter to include or exclude the defined attributes.
    /// </summary>
    [JsonPropertyName("action")]
    public Action Action { get; set; }

    /// <summary>
    /// The attributes to include or exclude.
    /// </summary>
    [JsonPropertyName("attributes")]
    public List<Filter> Attributes { get; set; }

    /// <summary>
    /// Initializer.
    /// </summary>
    /// <param name="action">Sets the filter to include or exclude the defined attributes.</param>
    /// <param name="attributes">The attributes to include or exclude.</param>
    public TraceAttributesFilter(Action action, List<Filter> attributes) {
        Action = action;
        Attributes = attributes;
    }

    /// <summary>
    /// Generates a TraceAttributesFilter including all attributes.
    /// </summary>
    public static TraceAttributesFilter All() => new(Action.Include, EnumExtensions.AllCases<Filter>());

    /// <summary>
    /// Generates a TraceAttributesFilter excluding all attributes.
    /// </summary>
    public static TraceAttributesFilter None() => new(Action.Exclude, EnumExtensions.AllCases<Filter>());
}