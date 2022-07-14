using FluentUnit.Dimensions;
using FluentUnit.Speed;
using FluentUnit.Time;

namespace FluentUnit.Distance;

public struct Kilometers : IDistanceUnit {
    public double Value { get; }

    public Kilometers(double value) {
        Value = value;
    }

    public static implicit operator Kilometers(double value) {
        return new Kilometers(value);
    }

    public static implicit operator double(Kilometers value) {
        return value.Value;
    }

    public static implicit operator Meters(Kilometers value) {
        return value.Value * 1000;
    }

    public static implicit operator Kilometers(Meters value) {
        return value.Value / 1000;
    }

    public static KilometersPerHour operator /(Kilometers distance, Hours time) {
        return distance.Value / time.Value;
    }

    public override string ToString() => $"{Value}km";
}
