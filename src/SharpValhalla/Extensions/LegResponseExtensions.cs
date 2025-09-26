using SharpValhalla.Models.Response;
using SharpValhalla.Models.Common;
using SharpValhalla.Utils;

namespace SharpValhalla.Extensions;

public static class LegResponseExtensions {
    /// <summary>
    /// Fetches the coordinates from a shape allowing a custom precision.
    /// </summary>
    /// <param name="leg">The LegResponse instance.</param>
    /// <param name="precision">The precision of the coordinates, defaulting to 1e-6.</param>
    /// <returns>A list of LocationCoordinate2D.</returns>
    public static List<LocationCoordinate2D> GetCoordinates(this LegResponse leg, double precision = 1e-6) {
        return string.IsNullOrEmpty(leg.Shape) ? [] : ShapeDecoding.DecodePolylineShape(leg.Shape, precision);
    }

    /// <summary>
    /// Fetches the coordinates from a shape with the default precision.
    /// This is a computed property instead of a function for improved performance.
    /// </summary>
    /// <param name="leg">The LegResponse instance.</param>
    /// <returns>A list of LocationCoordinate2D.</returns>
    public static List<LocationCoordinate2D> Coordinates(this LegResponse leg) {
        return string.IsNullOrEmpty(leg.Shape) ? [] : ShapeDecoding.DecodePolylineShape(leg.Shape);
    }
}

