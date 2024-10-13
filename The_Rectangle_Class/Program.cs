using The_Rectangle_Class;

// Test constructors and ToString()
Rectangle r1 = new Rectangle(1.2f, 3.4f);
Console.WriteLine(r1);  // ToString()

Rectangle r2 = new Rectangle();  // default constructor
Console.WriteLine(r2);

// Test setters and getters
r1.Length = 5.6f;
r1.Width = 7.8f;
Console.WriteLine(r1);  // ToString()
Console.WriteLine("Length is: " + r1.Length);
Console.WriteLine("Width is: " + r1.Width);

// Test GetArea() and GetPerimeter()
Console.WriteLine("Area is: " + r1.GetArea().ToString("F2"));
Console.WriteLine("Perimeter is: " + r1.GetPerimeter().ToString("F2"));