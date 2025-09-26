namespace SharpValhalla.Enums;

/// <summary>
/// An enum that pairs a travel mode with a specific subtype value.
/// Used to represent the concrete travel variant for a TravelMode.
/// </summary>
public abstract record TravelType {
    /// <summary>
    /// Drive travel type with a specific vehicle type.
    /// </summary>
    public sealed record Drive(VehicleType Vehicle) : TravelType {
        public VehicleType Vehicle { get; } = Vehicle;
    }
    /// <summary>
    /// Pedestrian travel type with a specific pedestrian type.
    /// </summary>
    public sealed record Pedestrian(PedestrianType PedestrianType) : TravelType {
        public PedestrianType PedestrianType { get; } = PedestrianType;
    }
    /// <summary>
    /// Bicycle travel type with a specific bicycle type.
    /// </summary>
    public sealed record Bicycle(BicycleType BicycleType) : TravelType {
        public BicycleType BicycleType { get; } = BicycleType;
    }
    /// <summary>
    /// Transit travel type with a specific transit type.
    /// </summary>
    public sealed record Transit(TransitType TransitType) : TravelType {
        public TransitType TransitType { get; } = TransitType;
    }
}