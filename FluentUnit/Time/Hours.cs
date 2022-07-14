using FluentUnit.Dimensions;

namespace FluentUnit.Time;

public struct Hours : ITimeUnit {
    public double Value { get; }

    public Hours(double value) {
        Value = value;
    }

    public override string ToString() => $"{Value} hours";

    public static implicit operator Hours(double value) => new Hours(value);
    public static implicit operator double(Hours hours) => hours.Value;

    public static Hours operator +(Hours left, Hours right) => new Hours(left.Value + right.Value);
    public static Hours operator -(Hours left, Hours right) => new Hours(left.Value - right.Value);
    public static Hours operator *(Hours hours, double number) => new Hours(hours.Value * number);
    public static Hours operator /(Hours hours, double number) => new Hours(hours.Value / number);
}
