using System;

struct Rectangle
{
    public int Width, Height;

    // Constructor to initialize the struct
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // Method to calculate area
    public int GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        // Creating instances of the struct
        Rectangle rect1 = new Rectangle(5, 10);
        Rectangle rect2 = rect1; // Structs are copied by value, not reference
        rect2.Width = 20;

        Console.WriteLine($"Rectangle 1: Width = {rect1.Width}, Height = {rect1.Height}, Area = {rect1.GetArea()}");
        Console.WriteLine($"Rectangle 2: Width = {rect2.Width}, Height = {rect2.Height}, Area = {rect2.GetArea()}");
    }
}