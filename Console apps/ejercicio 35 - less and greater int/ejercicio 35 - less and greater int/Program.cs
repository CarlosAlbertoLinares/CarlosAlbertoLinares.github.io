using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_35___less_and_greater_int
{
    //Write a C# program to check two given numbers where one is less than 100 and other is greater than 200.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo número");
            int y = Int32.Parse(Console.ReadLine());

            bool restult;

            if ((x < 100 && y > 200) || (x>200 && y<100))
            {
                Console.WriteLine(true);
            }
            else
                Console.WriteLine(false);

        }
    }
}
