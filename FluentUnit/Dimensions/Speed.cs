namespace FluentUnit.Dimensions;

public interface ISpeedUnit : IUnit { }

public struct Speed<TDist, TTime> : IDimension
    where TDist : IDistanceUnit
    where TTime : ITimeUnit {
    public Speed(double value) {
        Value = value;
    }

    public double Value { get; }
    
    // public static  Speed<TDist, TTime> operator /(Distance<TDist> a, Time<TTime> time) {
    //     
    // }
}
