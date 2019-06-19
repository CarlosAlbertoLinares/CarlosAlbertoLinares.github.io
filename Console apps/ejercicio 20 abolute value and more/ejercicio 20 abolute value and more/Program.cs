using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_20_abolute_value_and_more
{
    /* Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute 
    value of the difference if the first number is greater than second number.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el minuendo: ");
                int x = Int32.Parse(Console.ReadLine());
            Console.Write("ingrese el sustraendo: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.Write(operationA(x, y));

           

        }
        static int operationA(int a, int b)
        {
            int absoluteV = Math.Abs(a - b);
            return a > b ? absoluteV * 2 : absoluteV;

        }
    }
}
