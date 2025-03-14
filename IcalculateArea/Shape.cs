public abstract class Shape
{
    public string Name { get; set; }  // Property for Name

    // Constructor to initialize the name of the shape
    public Shape(string name)
    {
        Name = name;
    }

    // Abstract method for calculating the area, to be implemented by derived classes
    public abstract double CalculateArea();

    // Virtual method to display the shape's information
    public virtual void Display()
    {
        Console.WriteLine($"Shape: {Name}");
    }
}
