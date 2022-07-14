namespace FluentUnit.Dimensions;

public interface ITimeUnit : IUnit { }

public struct Time<T>:IDimension where T : ITimeUnit {
    public Time(double value) {
        Value = value;
    }
    public double Value { get; }
}
