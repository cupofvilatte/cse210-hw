using System;
public abstract class Shape {

    private string _color;

    public Shape(string color) {
        this._color = color;
    }

    public void SetColor(string color) {
        this._color = color;
    }

    public string GetColor() {
        return _color;
    }

    // public virtual float GetArea() {
    //    return 0;
    //}
    public abstract double GetArea();
}