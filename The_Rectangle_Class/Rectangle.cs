namespace The_Rectangle_Class;

public class Rectangle
{
    private float _length = 1.0f;
    private float _width = 1.0f;

    public float Length {
        get => _length;
        set {
            if (value > 0) {
                _length = value;
            } else {
                _length = 0;
            }
        }
    }
    public float Width {
        get => _width;
        set {
            if (value > 0) {
                _width = value;
            } else {
                _width = 0;
            }
        }
    }

    public Rectangle() {}

    public Rectangle(float length, float width) {
        Length = length;
        Width = width;
    }

    public double GetArea() { 
        return Length * Width;
    }
    public double GetPerimeter() { 
        return (Width * 2)+(Length * 2);
    }
    public override string ToString() {
        return $"Rectangle[length={Length},width={Width}]";
    }
}
