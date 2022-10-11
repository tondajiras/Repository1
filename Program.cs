using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soutez
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            double numA, numB, numC;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                numA = num1;
                numB = num2;
                numC = num3;
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                numA = num2;
                numB = num1;
                numC = num3;
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                numA = num3;
                numB = num2;
                numC = num1;
            }
            else
            {
                return;
            }
            double numa = numA*numA;
            double numb = numB*numB;
            double numc = numC*numC;

            if (numa == numb + numc)
            {
                Console.WriteLine("Trojúhelnik je pravoúhlý");
            }
            else
            {
                Console.WriteLine("Trojúhelnik není pravoúhlý");
            }
            Console.ReadKey();
        }
    }
}
