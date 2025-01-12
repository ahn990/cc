using System;
using System.Diagnostics;
class Figure
{
    public double Area()
    {
        return 0;
    }
}

class Triangle : Figure
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle (double baseLenght, double height)
    {
        Base = baseLenght;
        Height = height;
    }
    public  double Area() 
    {
        return (Base * Height) / 2;
    }
}
class Circle : Figure
{
    public double Radium { get; set; }

    public Circle(double radius) { 
    Radium = radius;
    }
    public  double Area()
    {
        return Math.PI * Radium;
    }
}
class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle (double width, double height)
    {
        Width = width;
        Height = height;
    }
    public  double Area()
    {
        return Width * Height;

    }
}
class Program
{
    static void Main(string[] args)
    {
        // Example usage of the Triangle class
        Triangle triangle = new Triangle(5, 10);
        Console.WriteLine($"Triangle Area: {triangle.Area()}");

        // Example usage of the Circle class
        Circle circle = new Circle(7);
        Console.WriteLine($"Circle Area: {circle.Area()}");

        // Example usage of the Rectangle class
        Rectangle rectangle = new Rectangle(4, 8);
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
    }
}
