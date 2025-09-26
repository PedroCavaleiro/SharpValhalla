using SharpValhalla.Models.Common;

namespace SharpValhalla.Interfaces;

/// <summary>
/// An interface for types that expose a geographic location.
/// Conforming types provide a Location property, typically representing the entity’s current or canonical position on Earth.
/// </summary>
public interface ILocation {
    /// <summary>
    /// The geographic coordinate of the instance.
    /// The coordinate uses the WGS 84 datum and represents latitude and longitude in degrees.
    /// </summary>
    public LocationCoordinate2D Location { get; }
}