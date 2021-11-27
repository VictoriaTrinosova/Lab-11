using System;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения kx+b=0");
            Equation equation;
            equation.k = 5;
            equation.b = 10;
            equation.Root();

        }
        struct Equation
        {
            public double k;
            public double b;
            public void Root()
            {
                double x;
                x = b / k;
                Console.WriteLine("x={0}", b / k);
            }

        }
    }
}
