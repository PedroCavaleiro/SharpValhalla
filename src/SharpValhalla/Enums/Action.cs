using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Indicates whether an item should be included or excluded when applying
/// filters or similar operations.
/// </summary>
public enum Action {
    /// <summary>
    /// Include the item when applying the filter.
    /// </summary>
    [Description("include")]
    Include,
    /// <summary>
    /// Exclude the item when applying the filter.
    /// </summary>
    [Description("exclude")]
    Exclude
    
}