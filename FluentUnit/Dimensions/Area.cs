namespace FluentUnit.Dimensions;

public interface IAreaUnit : IUnit { }

public struct Area<T1, T2> where T1 : IDistanceUnit where T2 : IDistanceUnit {
    public double Value;

    public Area(double value) {
        Value = value;
    }

    public static implicit operator Area<T1, T2>(double value) {
        return new Area<T1, T2>(value);
    }
}
