namespace FluentUnit.Speed;

public struct KilometersPerHour : IUnit {
    public KilometersPerHour(double value) {
        Value = value;
    }

    public double Value { get; }

    public static implicit operator KilometersPerHour(double value) {
        return new KilometersPerHour(value);
    }

    public static implicit operator MetersPerSecond(KilometersPerHour value) {
        return new MetersPerSecond(value.Value * 1000 / 3600);
    }
}
