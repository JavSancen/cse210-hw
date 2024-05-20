using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        // Create instances of shapes
        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 3, 5);
        Circle circle = new Circle("Green", 2);

        // Add shapes to the list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // Iterate through the list of shapes and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}