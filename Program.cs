using System;

namespace pole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer figury (1-koło, 2-trojkąt, 3-prostokąt): ");
            var figura = Convert.ToInt32(Console.ReadLine());
            switch(figura)
            {
                case 1:
                    Console.WriteLine("Podaj promień: ");
                    int promien = Convert.ToInt32(Console.ReadLine());
                    var polek = promien * promien * 3.14;
                    Console.WriteLine(polek);
                break;
                case 2:
                    Console.WriteLine("Podaj długość podstawy: ");
                    int podstawa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj wysokość: ");
                    int wysokosc = Convert.ToInt32(Console.ReadLine());
                    var polet = 0.5 * podstawa * wysokosc;
                    Console.WriteLine(polet);
                break;
                case 3:
                    Console.WriteLine("Podaj długość boku: ");
                    int bok = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj wysokość: ");
                    int wys = Convert.ToInt32(Console.ReadLine());
                    var polep = bok * wys;
                    Console.WriteLine(polep);
                break;
                default:
                    Console.WriteLine("Podano zły numer");
                break;
            }
            
        }
    }
}
