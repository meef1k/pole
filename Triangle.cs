using System;
namespace pole
{
    public class Triangle : IFigure
    {
            public int a;
            public int b;
            public int c;
            public int h;
            public void getValues()
            {
                Console.WriteLine("Podaj a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj b: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj c: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj h: ");
                int h = Convert.ToInt32(Console.ReadLine());
            }
            public double area()
            {
                return 0.5 * a * h;
            }
            public double primeter()
            {
                return a + b + c;
            }
    }
}
