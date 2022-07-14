using FluentUnit.Dimensions;

namespace FluentUnit.Time;

public readonly struct Minutes : ITimeUnit {
    public Minutes(double value) {
        Value = value;
    }

    public double Value { get; }

    public static implicit operator Seconds(Minutes minutes) {
        return new Seconds(minutes.Value * 60);
    }

    public static implicit operator Hours(Minutes minutes) {
        return new Hours(minutes.Value / 60);
    }

    public static implicit operator TimeSpan(Minutes minutes) {
        return TimeSpan.FromMinutes(minutes.Value);
    }
    
    public static implicit operator Minutes(TimeSpan timeSpan) {
        return new Minutes(timeSpan.TotalMinutes);
    }

    public override string ToString() => $"{Value} minutes";
}
