using FluentUnit.Dimensions;

namespace FluentUnit.Time;

public readonly struct Seconds : ITimeUnit {
    public Seconds(double value) {
        Value = value;
    }

    public double Value { get; }

    public static implicit operator TimeSpan(Seconds seconds) {
        return TimeSpan.FromSeconds(seconds.Value);
    }

    public static implicit operator Minutes(Seconds seconds) {
        return new Minutes(seconds.Value / 60);
    }

    public static implicit operator Hours(Seconds seconds) {
        return new Hours(seconds.Value / 3600);
    }

    public static implicit operator Milliseconds(Seconds seconds) {
        return new Milliseconds(seconds.Value * 1000);
    }

    public override string ToString() => $"{Value}s";
}
