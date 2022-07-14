using FluentUnit.Dimensions;

namespace FluentUnit.Distance;

public struct Millimeters : IDistanceUnit {
    public Millimeters(double value) {
        Value = value;
    }

    public double Value { get; }

    public static implicit operator Meters(Millimeters value) {
        return new Meters(value.Value / 1000);
    }

    public static implicit operator Millimeters(Meters value) {
        return new Millimeters(value.Value * 1000);
    }

    public override string ToString() => $"{Value}mm";
}
