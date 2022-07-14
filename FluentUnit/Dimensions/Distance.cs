namespace FluentUnit.Dimensions;

public interface IDistanceUnit : IUnit { }

public struct Distance<T> where T : IDistanceUnit {
    public Distance(double value) {
        Value = value;
    }

    public double Value { get; }

    // public static Time<T, TTime> operator /(Distance<T> value1, Time<TTime> value2) {
    //     return value1.Value * value2.Value;
    // }
}
