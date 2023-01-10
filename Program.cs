using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hodina11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            bool active = true;
            while (active)
            {
                string vstup = Console.ReadLine();
                if (vstup == "n")
                {
                    break;
                }
                if(!int.TryParse(vstup, out int cislo))
                {
                    Console.WriteLine("spatne");
                    continue;
                }
                list.Add(cislo);
            }
            Console.WriteLine("--------------------------");
            list.Sort();
            foreach (int op in list)
            {
                Console.WriteLine(op);
            }
            Console.ReadKey();
        }
    }
}
