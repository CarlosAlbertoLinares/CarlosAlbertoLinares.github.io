using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_22_can_i_reach_200_or_100_in_20
{
    //**Write a C# program to check if an given integer is within 20 of 100 or 200.**
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("favor de ingresar el número entero");
            int input = Int32.Parse(Console.ReadLine());
         
                Console.Write(100-input == 20 || 200-input == 20 ? true : false);

                



        }
    }
}
