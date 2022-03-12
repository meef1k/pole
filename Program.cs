using System;

namespace pole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer figury (1-koło, 2-trojkąt, 3-kwadrat): ");
            string choose = Console.ReadLine();
            IFigure fr = null;
            if (choose == "1")
            {
                fr = new Circle();
            }
            else if (choose == "2")
            {
                fr = new Triangle();
            }
            else if (choose == "3")
            {
                fr = new Square();
            }
            fr.getValues();
            Console.WriteLine("Co liczymy (1-pole, 2-obwód)? ");
            choose = Console.ReadLine();
            if (choose == "1")
            {
                Console.WriteLine(fr.area());
            }
            else if (choose == "2")
            {
                Console.WriteLine(fr.primeter());
            }
        }
    }
}
