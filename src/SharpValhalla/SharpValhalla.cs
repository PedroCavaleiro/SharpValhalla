using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using SharpExtended;
using SharpExtended.JsonConverters;
using SharpValhalla.Models.Request;
using SharpValhalla.Models.Response.BaseResponses;

namespace SharpValhalla;

/// <summary>
/// Provides methods to interact with a Valhalla server for routing and matrix calculations.
/// </summary>
public class SharpValhalla(string serverUrl) {
    /// <summary>
    /// The base URL of the Valhalla server, with trailing slash removed.
    /// </summary>
    private string ServerUrl { get; } = serverUrl.TrimEnd('/');
    
    /// <summary>
    /// Configuration for JSON serialization, including custom converters and number handling.
    /// </summary>
    private static readonly JsonSerializerOptions JsonConfiguration = new() {
        Converters = {
            new EnumDescriptionConverter()
        },
        AllowTrailingCommas = true,
        NumberHandling = JsonNumberHandling.AllowReadingFromString
    };

    /// <summary>
    /// Sends a map matching request to the Valhalla server and returns the response.
    /// </summary>
    /// <param name="data">The map matching request data.</param>
    /// <returns>The map matching response, or null if unsuccessful.</returns>
    /// <exception cref="Exception">Thrown if the HTTP request fails.</exception>
    public async Task<MapMatchingResponse?> MapMatching(MapMatchingRequest data) {
        using var client = new HttpClient();
        using var request = new HttpRequestMessage(
            new HttpMethod("POST"),
            $"{ServerUrl}/trace_route"
        );
        
        request.Content = new StringContent(
            data.Serialize(JsonConfiguration),
            System.Text.Encoding.UTF8, "application/json"
        );
        
        request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        
        var response = await client.SendAsync(request);
        
        if (response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<MapMatchingResponse>(JsonConfiguration);
        
        throw new Exception(
            $"HTTP status {response.StatusCode}", 
            innerException: new Exception(response.Content.ReadAsStringAsync().Result)
        );
        
    }
    
    /// <summary>
    /// Sends a matrix request to the Valhalla server and returns the response.
    /// </summary>
    /// <param name="data">The matrix request data.</param>
    /// <returns>The matrix response, or null if unsuccessful.</returns>
    /// <exception cref="Exception">Thrown if the HTTP request fails.</exception>
    public async Task<MatrixResponse?> Matrix(MatrixRequest data) {
        using var client = new HttpClient();
        
        var json = data.Serialize(JsonConfiguration);
        
        using var request = new HttpRequestMessage(
            new HttpMethod("GET"),
            $"{ServerUrl}/sources_to_targets&json={Uri.EscapeDataString(json)}"
        );
        
        var response = await client.SendAsync(request);
        
        if (response.IsSuccessStatusCode)
            return await response.Content.ReadFromJsonAsync<MatrixResponse>(JsonConfiguration);
        
        throw new Exception(
            $"HTTP status {response.StatusCode}", 
            innerException: new Exception(response.Content.ReadAsStringAsync().Result)
        );
        
    }
    
}