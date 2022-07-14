namespace FluentUnit.Time;

public static class Extension {
    public static Seconds Hours(this double hours) {
        return new Seconds(hours * 60 * 60);
    }

    public static Minutes Minutes(this double minutes) {
        return new Seconds(minutes * 60);
    }

    public static Seconds Seconds(this double seconds) {
        return new Seconds(seconds);
    }

    public static Milliseconds Milliseconds(this double milliseconds) {
        return new Milliseconds(milliseconds);
    }
}
