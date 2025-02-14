using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine("");


        List<Shape> shapes= new List<Shape>();

        Square shape1 = new Square ("Purple", 5);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Yellow", 3,7);
        shapes.Add(shape2);

        Circle shape3 = new Circle ("Pink", 5);
        shapes.Add(shape3);



        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }
}