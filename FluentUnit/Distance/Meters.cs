using FluentUnit.Dimensions;
using FluentUnit.Speed;
using FluentUnit.Time;

namespace FluentUnit.Distance;

public readonly struct Meters : IDistanceUnit {
    public double Value { get; }

    public Meters(double value) {
        Value = value;
    }

    public static implicit operator Meters(double value) {
        return new Meters(value);
    }

    public static implicit operator double(Meters value) {
        return value.Value;
    }

    public static MetersPerSecond operator /(Meters value, Seconds seconds) {
        return new MetersPerSecond(value.Value / seconds.Value);
    }

    public static Meters operator *(Meters meters, double value) {
        return meters.Value * value;
    }

    public static MeterSquare operator *(Meters value1, Meters value2) {
        return value1.Value * value2.Value;
    }

    public static Meters operator +(Meters value1, Meters value2) {
        return value1.Value + value2.Value;
    }

    public static Meters operator -(Meters value1, Meters value2) {
        return value1.Value + value2.Value;
    }

    public override string ToString() => $"{Value}m";
}
