namespace The_Ball_Class;

public class Ball
{
    private float _x;
    private float _y;
    private int _radius;
    private float _xDelta;
    private float _yDelta;

    public float X {get => _x; set => _x = value;}
    public float Y { get => _y; set => _y = value; }
    public int Radius {get => _radius; set => _radius = value;}
    public float XDelta {get => _xDelta; set => _xDelta = value;}
    public float YDelta { get => _yDelta; set => _yDelta = value;}

    public Ball(float x, float y, int radius, float xDelta, float yDelta) { }

    public void Move() {
        X += XDelta;
        Y += YDelta;
    }
    public void ReflectHorizontal() {
        XDelta = -XDelta;

    }
    public void ReflectVertical() { 
        YDelta = -YDelta;
    }
    public override string ToString() {
        return $"Ball[({X:F2},{Y:F2}),speed=({XDelta:F2},{YDelta:F2})]";
    }
}