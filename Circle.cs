using System;
namespace pole
{
    public class Circle : IFigure
    {
            public int r;
            public void getValues()
            {
                Console.WriteLine("Podaj promień: ");
                int r = Convert.ToInt32(Console.ReadLine());
            }
            public double area()
            {
                return r * r * 3.14;
            }
            public double primeter()
            { 
                return 2 * r * 3.14;
            }
    }
}
