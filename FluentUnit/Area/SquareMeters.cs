using FluentUnit.Dimensions;

namespace FluentUnit.Area;

public struct SquareMeters : IAreaUnit {
    public SquareMeters(double value) {
        Value = value;
    }

    public double Value { get; }
}
