# SharpValhalla

A .NET library for interfacing with Valhalla routing services, providing a clean and strongly-typed C# API for map matching, matrix calculations, and routing operations.

## Features

- **Map Matching**: Match GPS traces to road networks with high accuracy
- **Matrix Calculations**: Compute travel time and distance matrices between multiple locations
- **Strongly Typed**: Full type safety with comprehensive enums and models
- **Modern .NET**: Built for .NET 9.0 with nullable reference types
- **Polyline Decoding**: Built-in utilities for decoding Valhalla/Google polyline formats
- **Flexible Costing**: Support for all Valhalla costing models (auto, bicycle, pedestrian, bus, bikeshare, taxi, etc.)

## Installation

```bash
# Package will be available on NuGet (when published)
dotnet add package SharpValhalla
```

## Quick Start

```csharp
using SharpValhalla;
using SharpValhalla.Models.Request;
using SharpValhalla.Models.Common;
using SharpValhalla.Enums;

// Initialize the client with your Valhalla server URL
var valhalla = new SharpValhalla("https://your-valhalla-server.com");

// Create locations for matrix calculation
var locations = new List<Location> {
    new Location(40.7589, -73.9851), // Times Square, NYC
    new Location(40.6892, -74.0445), // Statue of Liberty
    new Location(40.7505, -73.9934)  // Empire State Building
};

// Calculate travel matrix
var matrixRequest = new MatrixRequest(
    sources: locations,
    costing: CostingModel.Auto
);

var matrixResponse = await valhalla.Matrix(matrixRequest);
if (matrixResponse != null) {
    // Process travel times and distances
    foreach (var element in matrixResponse.SourcesToTargets) {
        Console.WriteLine($"Distance: {element.Distance} km, Time: {element.Time} seconds");
    }
}
```

## Map Matching Example

```csharp
// GPS trace points
var gpsTrace = new List<Location> {
    new Location(40.7589, -73.9851),
    new Location(40.7590, -73.9852),
    new Location(40.7591, -73.9853)
};

// Create map matching request
var mapMatchRequest = new MapMatchingRequest(
    shape: gpsTrace,
    costing: CostingModel.Auto,
    shapeMatch: ShapeMatch.EdgeWalk
);

var response = await valhalla.MapMatching(mapMatchRequest);
if (response != null) {
    // Access matched route information
    foreach (var leg in response.Legs) {
        Console.WriteLine($"Matched leg distance: {leg.Summary.Length} km");
    }
}
```

## Supported Costing Models

SharpValhalla supports all Valhalla costing models:

- **Auto**: Standard driving routes for cars, motorcycles, trucks
- **Bicycle**: Bicycle routing with preference for bike lanes and cycleways  
- **Pedestrian**: Walking routes on pedestrian-accessible paths
- **Bus**: Public bus routing with bus-specific road access
- **Bikeshare**: Combined pedestrian and bicycle routing with bike share stations
- **Taxi**: Taxi routing with appropriate road access and preferences
- **Motorcycle**: Motorcycle-specific routing
- **Transit**: Public transit routing

## Key Classes and Models

### Core Client
- `SharpValhalla`: Main client class for API interactions

### Request Models
- `MatrixRequest`: For travel time/distance matrix calculations
- `MapMatchingRequest`: For GPS trace map matching operations
- `DirectionsOptions`: Configure output format, language, and units
- `TraceOptions`: Fine-tune map matching behavior

### Response Models
- `MatrixResponse`: Contains travel matrices with times and distances
- `MapMatchingResponse`: Contains matched routes with detailed information
- `RouteResponse`: Detailed route information including legs and maneuvers

### Location Types
- `Location`: Geographic coordinate with optional metadata
- `LocationCoordinate2D`: Simple latitude/longitude coordinate pair
- `ILocation`: Interface for location-aware objects

### Utilities
- `ShapeDecoding`: Decode Valhalla/Google polyline-encoded shapes
- Various extension methods for enhanced functionality

## Configuration Options

### Costing Options
Customize routing behavior with `CostingOptions`:

```csharp
var costingOptions = new CostingOptions {
    // Vehicle-specific options
    // Avoidance preferences  
    // Speed and routing preferences
};

var request = new MatrixRequest(
    sources: locations,
    costing: CostingModel.Auto,
    costingOptions: costingOptions
);
```

### Trace Options
Fine-tune map matching with `TraceOptions`:

```csharp
var traceOptions = new TraceOptions {
    // Matching accuracy settings
    // GPS noise tolerance
    // Smoothing parameters
};
```

## Error Handling

SharpValhalla throws exceptions for HTTP errors:

```csharp
try {
    var response = await valhalla.Matrix(request);
    // Process successful response
}
catch (Exception ex) {
    // Handle HTTP errors or network issues
    Console.WriteLine($"Request failed: {ex.Message}");
}
```

## Dependencies

- **.NET 9.0**: Modern .NET runtime
- **SharpExtended**: Extended functionality and JSON converters

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs and feature requests.

## License

This project is licensed under the terms specified in the LICENSE file.

## Valhalla Server

This library requires a Valhalla routing server. You can:
- Set up your own Valhalla instance
- Use a hosted Valhalla service
- Run Valhalla in Docker for development

For more information about Valhalla, visit the [official documentation](https://valhalla.github.io/valhalla/).