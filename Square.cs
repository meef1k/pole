using System;
namespace pole
{
    public class Square : IFigure
    {
            public int a;
            public void getValues()
            {
                Console.WriteLine("Podaj bok: ");
                int a = Convert.ToInt32(Console.ReadLine());
            }
            public double area()
            {
                return a * a;
            }
            public double primeter()
            {
                return 4 * a;
            }
    }
}
