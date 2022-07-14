using FluentUnit.Dimensions;

namespace FluentUnit.Time;

public struct Milliseconds : ITimeUnit {
    public Milliseconds(double value) {
        Value = value;
    }

    public double Value { get; }

    public static implicit operator Seconds(Milliseconds value) {
        return new Seconds(value.Value / 1000);
    }

    public override string ToString() {
        return $"{Value}ms";
    }
}
