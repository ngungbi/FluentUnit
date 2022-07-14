using FluentUnit.Dimensions;

namespace FluentUnit.Time;

public readonly struct Days : ITimeUnit {
    public Days(double value) {
        Value = value;
    }

    public double Value { get; }

    public static implicit operator TimeSpan(Days days) {
        return TimeSpan.FromDays(days.Value);
    }

    public static implicit operator Hours(Days days) {
        return new Hours(days.Value * 24);
    }

    public static implicit operator Minutes(Days days) {
        return new Minutes(days.Value * 24 * 60);
    }

    public static implicit operator Seconds(Days days) {
        return new Seconds(days.Value * 24 * 60 * 60);
    }

    public override string ToString() => $"{Value} days";
}
