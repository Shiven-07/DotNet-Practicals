using System;

namespace DelegateArithmetic
{
    delegate double MathOp(double a, double b);

    class Arithmetic
    {
        public static double Add(double a, double b)      => a + b;
        public static double Multiply(double a, double b) => a * b;
        public static double Subtract(double a, double b) => a - b;
        public static double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Arithmetic via Delegates ===");
            double x = 10, y = 5;

            MathOp op = Arithmetic.Add;
            Console.WriteLine($"Add({x},{y})       = {op(x, y)}");

            op = Arithmetic.Subtract;
            Console.WriteLine($"Subtract({x},{y}) = {op(x, y)}");

            op = Arithmetic.Multiply;
            Console.WriteLine($"Multiply({x},{y}) = {op(x, y)}");

op = Arithmetic.Divide;
            Console.WriteLine($"Divide({x},{y})   = {op(x, y)}");

            Console.ReadKey();
        }
    }
}
