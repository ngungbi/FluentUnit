namespace FluentUnit.Distance;

public static class Extension {
    public static Kilometers Kilometers(this double value) {
        return new Kilometers(value);
    }

    public static Meters Centimeters(this double value) {
        return new Meters(value / 100);
    }

    public static Meters Millimeters(this double value) {
        return new Meters(value / 1000);
    }

    public static Meters Meters(this double value) {
        return new Meters(value);
    }

    public static Meters Miles(this double value) {
        return new Meters(value * 1.609344 * 1000);
    }

    public static Kilometers LightYears(this double value) {
        return new Kilometers(value * 9460730472580800);
    }
}
