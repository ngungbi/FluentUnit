using FluentUnit.Dimensions;

namespace FluentUnit.Speed;

public struct MetersPerSecond : ISpeedUnit {
    public MetersPerSecond(double value) {
        Value = value;
    }

    public double Value { get; }

    public static implicit operator KilometersPerHour(MetersPerSecond value) {
        return new KilometersPerHour(value.Value * 3.6);
    }
}
