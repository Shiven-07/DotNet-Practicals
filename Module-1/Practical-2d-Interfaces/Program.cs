using System;
namespace InterfaceDemo
{
    // Define interfaces
    interface IShape
    {
        double Area();
        double Perimeter();
        void Display();
    }

    interface IPrintable
    {
        void Print();
    }

    class Circle : IShape, IPrintable
    {
        private double radius;
        public Circle(double r) { radius = r; }

        public double Area() => Math.PI * radius * radius;
        public double Perimeter() => 2 * Math.PI * radius;
        public void Display()
        {
            Console.WriteLine($"Circle: Radius={radius}");
            Console.WriteLine($"   Area      = {Area():F2}");
            Console.WriteLine($"   Perimeter = {Perimeter():F2}");
        }
        public void Print() => Console.WriteLine("[Printable] Circle Info Printed.");
    }

    class Rectangle : IShape

{
        private double length, width;
        public Rectangle(double l, double w) { length = l; width = w; }

        public double Area() => length * width;
        public double Perimeter() => 2 * (length + width);
        public void Display()
        {
            Console.WriteLine($"Rectangle: Length={length}, Width={width}");
            Console.WriteLine($"   Area      = {Area():F2}");
            Console.WriteLine($"   Perimeter = {Perimeter():F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interface Demo ===");
            IShape c = new Circle(7.0);
            c.Display();
            ((IPrintable)c).Print();

            Console.WriteLine();
            IShape r = new Rectangle(5.0, 3.0);
            r.Display();
            Console.ReadKey();
        }
    }
}
