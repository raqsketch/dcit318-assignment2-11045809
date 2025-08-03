using System;

class Program
{
    static void Main(string[] args)
    {
        // Previous code...

        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.GetArea()}");        // Output: Circle Area: 78.53981633974483
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");  // Output: Rectangle Area: 24
    }
}
     
