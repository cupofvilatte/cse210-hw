public class Fraction {
    private int _topNumber;
    private int _bottomNumber;

    public Fraction() {
        _bottomNumber = 1;
        _topNumber = 1;
    }
    public Fraction(int wholeNumber) {
        _bottomNumber = 1;
        _topNumber = wholeNumber;
    }
    public Fraction(int top, int bottom) {
        _bottomNumber = bottom;
        _topNumber = top;
    }

    public string GetFraction() {
        string fraction = $"{_topNumber}/{_bottomNumber}";
        return fraction;
    }

    public double GetDecimal() {
        return (double)_topNumber / (double)_bottomNumber;
    }
}