using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Purple", 5);
        shapes.Add(s1);

        Circle c1 = new Circle("Green", 3);
        shapes.Add(c1);

        Rectangle r1 = new Rectangle("Grey", 4, 2);
        shapes.Add(r1);

        foreach (Shape s in shapes) {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The shape is {color} and the area is {area}.");
        }
    }
}