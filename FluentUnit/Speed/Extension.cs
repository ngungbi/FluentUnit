namespace FluentUnit.Speed;

public static class Extension {
    public static MetersPerSecond MetersPerSecond(this double value) {
        return new MetersPerSecond(value);
    }

    public static MetersPerSecond MilesPerHour(this double value) {
        return new MetersPerSecond(value * 0.44704);
    }

    public static KilometersPerHour KilometersPerHour(this double value) {
        return new KilometersPerHour(value);
    }


    public static MetersPerSecond Knots(this double value) {
        return new MetersPerSecond(value * 0.514444444);
    }
}
