namespace FluentUnit; 

public struct MeterSquare {
    public double Value;
    public MeterSquare(double value) {
        Value = value;
    }
    public static implicit operator MeterSquare(double value) {
        return new MeterSquare(value);
    }
}
