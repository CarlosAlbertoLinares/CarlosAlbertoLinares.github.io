using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_25___print_off_int_from_1_to_99
{
    /*Write a C# program to print the odd numbers from 1 to 99. 
    Prints one number per line.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Este programa presenta los numero impares del 1 al 100\n");
            for (int x=0;x<100;x++)
            {

                if(x%2!=0)
                {
                    Console.WriteLine(x);
                }


            }
        }
    }
}
