using System.ComponentModel;

namespace SharpValhalla.Enums;

/// <summary>
/// The language of the narration instructions based on the IETF BCP 47 language tag string. If no language is specified or the specified language is unsupported, United States-based English (en-US) is used.
/// </summary>
public enum Language {
    /// <summary>Bulgarian</summary>
    [Description("bg-BG")]
    Bulgarian,
    /// <summary>Catalan</summary>
    [Description("ca-ES")]
    Catalan,
    /// <summary>Czech</summary>
    [Description("cs-CZ")]
    Czech,
    /// <summary>Danish</summary>
    [Description("da-DK")]
    Danish,
    /// <summary>German</summary>
    [Description("de-DE")]
    German,
    /// <summary>Greek</summary>
    [Description("el-GR")]
    Greek,
    /// <summary>English (United States)</summary>
    [Description("en-US")]
    EnglishUnitedStates,
    /// <summary>English (United Kingdom)</summary>
    [Description("en-GB")]
    EnglishUnitedKingdom,
    /// <summary>English (Pirate)</summary>
    [Description("en-US-x-pirate")]
    EnglishPirate,
    /// <summary>Spanish</summary>
    [Description("es-ES")]
    Spanish,
    /// <summary>Estonian</summary>
    [Description("et-EE")]
    Estonian,
    /// <summary>Finnish</summary>
    [Description("fi-FI")]
    Finnish,
    /// <summary>French</summary>
    [Description("fr-FR")]
    French,
    /// <summary>Hindi</summary>
    [Description("hi-IN")]
    Hindi,
    /// <summary>Hungarian</summary>
    [Description("hu-HU")]
    Hungarian,
    /// <summary>Italian</summary>
    [Description("it-IT")]
    Italian,
    /// <summary>Japanese</summary>
    [Description("ja-JP")]
    Japanese,
    /// <summary>Bokmal Norwegian</summary>
    [Description("nb-NO")]
    BokmalNorwegian,
    /// <summary>Dutch</summary>
    [Description("nl-NL")]
    Dutch,
    /// <summary>Polish</summary>
    [Description("pl-PL")]
    Polish,
    /// <summary>Portuguese (Portugal)</summary>
    [Description("pt-PT")]
    PortuguesePortugal,
    /// <summary>Portuguese (Brazil)</summary>
    [Description("pt-BR")]
    PortugueseBrazil,
    /// <summary>Romanian</summary>
    [Description("ro-RO")]
    Romanian,
    /// <summary>Russian</summary>
    [Description("ru-RU")]
    Russian,
    /// <summary>Slovak</summary>
    [Description("sk-SK")]
    Slovak,
    /// <summary>Slovenian</summary>
    [Description("sl-SI")]
    Slovenian,
    /// <summary>Swedish</summary>
    [Description("sv-SE")]
    Swedish,
    /// <summary>Turkish</summary>
    [Description("tr-TR")]
    Turkish,
    /// <summary>Ukrainian</summary>
    [Description("uk-UA")]
    Ukrainian
}