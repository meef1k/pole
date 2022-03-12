using System;
namespace pole
{
    public class Triangle : IFigure
    {
            int a;
            int b;
            int c;
            int h;
            public void getValues()
            {
                Console.WriteLine("Podaj a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj b: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj c: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj h: ");
                h = Convert.ToInt32(Console.ReadLine());
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
