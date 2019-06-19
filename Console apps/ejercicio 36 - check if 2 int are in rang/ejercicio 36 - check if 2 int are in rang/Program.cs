using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_36___check_if_2_int_are_in_rang
{
    //Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());

            if ((x >= -10 && x <= 10) && (y >= -10 && y <= 10))
            {
                Console.WriteLine(true);
            }
            else
                Console.WriteLine(false);
        }
    }
}
