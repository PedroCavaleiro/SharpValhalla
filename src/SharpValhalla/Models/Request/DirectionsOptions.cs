using System.Text.Json.Serialization;
using SharpValhalla.Enums;
// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable AutoPropertyCanBeMadeGetOnly.Global
// ReSharper disable MemberCanBePrivate.Global

namespace SharpValhalla.Models.Request;

/// <summary>
/// Directions options structure
/// </summary>
public class DirectionsOptions {
    [JsonPropertyName("units")]
    public Unit Units { get; set; }
    [JsonPropertyName("language")]
    public Language Language { get; set; }
    [JsonPropertyName("directions_type")]
    public DirectionType DirectionsType { get; set; }
    [JsonPropertyName("format")]
    public Format Format { get; set; }
    [JsonPropertyName("shape_format")]
    public ShapeFormat? ShapeFormat { get; set; }
    [JsonPropertyName("banner_instructions")]
    public bool BannerInstructions { get; set; }
    [JsonPropertyName("voice_instructions")]
    public bool VoiceInstructions { get; set; }
    [JsonPropertyName("alternates")]
    public int? Alternates { get; set; }

    /// <summary>
    /// Initializer for DirectionsOptions.
    /// </summary>
    public DirectionsOptions(
        Unit units = Unit.Kilometers,
        Language language = Language.EnglishUnitedStates,
        DirectionType directionsType = DirectionType.None,
        Format format = Format.Json,
        ShapeFormat? shapeFormat = null,
        bool bannerInstructions = true,
        bool voiceInstructions = true,
        int? alternates = null
    ) {
        Units = units;
        Language = language;
        DirectionsType = directionsType;
        Format = format;
        Alternates = alternates;
        if (format == Format.Osrm) {
            BannerInstructions = bannerInstructions;
            VoiceInstructions = voiceInstructions;
            ShapeFormat = shapeFormat ?? Enums.ShapeFormat.Polyline6;
        } else {
            BannerInstructions = false;
            VoiceInstructions = false;
            ShapeFormat = null;
        }
    }
}