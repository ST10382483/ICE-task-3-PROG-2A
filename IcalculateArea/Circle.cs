public class Circle : Shape
{
    public double Radius { get; set; }

    // Constructor to initialize name and radius
    public Circle(string name, double radius)
        : base(name)
    {
        Radius = radius;
    }

    // Implementing the CalculateArea method
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;  // Area = π * radius^2
    }

    // Overriding the Display method to include Circle-specific details
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Radius: {Radius}");
    }
}
