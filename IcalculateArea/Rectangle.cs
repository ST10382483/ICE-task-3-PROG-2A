public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Constructor to initialize name, width, and height
    public Rectangle(string name, double width, double height)
        : base(name)
    {
        Width = width;
        Height = height;
    }

    // Implementing the CalculateArea method
    public override double CalculateArea()
    {
        return Width * Height;  // Area = width * height
    }

    // Overriding the Display method to include Rectangle-specific details
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Width: {Width}, Height: {Height}");
    }
}
