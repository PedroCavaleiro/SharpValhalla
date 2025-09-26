using SharpValhalla.Models.Common;

namespace SharpValhalla.Utils;

public static class ShapeDecoding {
    /// <summary>
    /// Decodes a Valhalla/Google-style polyline-encoded string into an array of geographic coordinates.
    /// This was converted from the Python sample in the valhalla docs: https://valhalla.github.io/valhalla/decoding/#python
    /// </summary>
    /// <param name="encoded">The encoded polyline string to decode.</param>
    /// <param name="precision">The scaling factor used when encoding coordinates. Defaults to 1e-6.</param>
    /// <returns>An array of LocationCoordinate2D objects representing the decoded path.</returns>
    public static List<LocationCoordinate2D> DecodePolylineShape(string encoded, double precision = 1e-6) {
        var decoded = new List<LocationCoordinate2D>();
        int lat     = 0, lon = 0;
        var index   = 0;
        var length  = encoded.Length;

        while (index < length) {
            var coord = new int[2];
            for (var j = 0; j < 2; j++) {
                var shift  = 0;
                var result = 0;
                int b;
                do {
                    b      =  encoded[index++] - 63;
                    result |= (b & 0x1f) << shift;
                    shift  += 5;
                } while (b >= 0x20 && index < length);
                var delta = ((result & 1) != 0) ? ~(result >> 1) : (result >> 1);
                if (j == 0) {
                    lat      += delta;
                    coord[0] =  lat;
                } else {
                    lon      += delta;
                    coord[1] =  lon;
                }
            }
            var latitude  = coord[0] * precision;
            var longitude = coord[1] * precision;
            decoded.Add(new LocationCoordinate2D(latitude, longitude));
        }
        return decoded;
    }
}