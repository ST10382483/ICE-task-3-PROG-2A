class Program
{
    static void Main(string[] args)
    {
        // Create a Rectangle and Circle object
        Shape rectangle = new Rectangle("Rectangle", 5.0, 10.0);
        Shape circle = new Circle("Circle", 7.0);

        // Display shape details and area
        rectangle.Display();
        Console.WriteLine($"Area: {rectangle.CalculateArea()}\n");

        circle.Display();
        Console.WriteLine($"Area: {circle.CalculateArea()}");

        Console.ReadLine();  // Wait for user input before closing the console
    }
}
