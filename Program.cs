using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttak3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            int cislo2;
            int rozdil;

            Console.WriteLine("zadej 1 číslo");
            cislo = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej 2 cislo");
            cislo2 = int.Parse(Console.ReadLine());

            if (cislo == cislo2)
            {
                Console.WriteLine("čísla jsou stejná");
                return;
            }
            else
            {
                Console.WriteLine("čísla jsou jiná");

                if (cislo > cislo2)
                {
                    rozdil = cislo - cislo2;
                }
                else if (cislo < cislo2)
                {
                    rozdil = cislo2 - cislo;
                }
                else
                {
                    rozdil = 0;
                }
                Console.WriteLine("Rozdíl čísel je: " + rozdil);
            }
            Console.ReadKey();
        }
    }
}
