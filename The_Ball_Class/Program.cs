using The_Ball_Class;

// Test constructor and ToString()
Ball ball = new Ball(1.1f, 2.2f, 10, 3.3f, 4.4f);
Console.WriteLine(ball);  // ToString()

// Test Setters and Getters
ball.X = 80.0f;
ball.Y = 35.0f;
ball.Radius = 5;
ball.XDelta = 4.0f;
ball.YDelta = 6.0f;
Console.WriteLine(ball);  // ToString()
Console.WriteLine("x is: " + ball.X.ToString("F2"));
Console.WriteLine("y is: " + ball.Y.ToString("F2"));
Console.WriteLine("radius is: " + ball.Radius);
Console.WriteLine("xDelta is: " + ball.XDelta.ToString("F2"));
Console.WriteLine("yDelta is: " + ball.YDelta.ToString("F2"));

// Bounce the ball within the boundary
float xMin = 0.0f;
float xMax = 100.0f;
float yMin = 0.0f;
float yMax = 50.0f;
for (int i = 0; i < 15; i++) {
    ball.Move();
    Console.WriteLine(ball);
    float xNew = ball.X;
    float yNew = ball.Y;
    int radius = ball.Radius;

    // Check boundary value to bounce back
    if ((xNew + radius) > xMax || (xNew - radius) < xMin) {
        ball.ReflectHorizontal();
    }
    if ((yNew + radius) > yMax || (yNew - radius) < yMin) {
        ball.ReflectVertical();
    }
}