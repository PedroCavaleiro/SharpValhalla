using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// Represents the different flow speed types for edges in Valhalla routing.
///
/// Each case corresponds to a specific traffic flow condition.
/// The raw value matches the exact key string used in Valhalla.
/// </summary>
public enum FlowSpeeds {
    /// <summary>
    /// Current traffic flow condition.
    /// </summary>
    [Description("current_flow")]
    CurrentFlow,
    /// <summary>
    /// Constrained traffic flow condition.
    /// </summary>
    [Description("constrained_flow")]
    ConstrainedFlow,
    /// <summary>
    /// Free traffic flow condition.
    /// </summary>
    [Description("free_flow")]
    FreeFlow,
    /// <summary>
    /// Predicted traffic flow condition.
    /// </summary>
    [Description("predicted_flow")]
    PredictedFlow,
    /// <summary>
    /// No traffic flow data available.
    /// </summary>
    [Description("no_flow")]
    NoFlow
}