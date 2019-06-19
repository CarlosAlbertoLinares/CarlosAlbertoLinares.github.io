using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_21_sum_of_2_input_int_with_if
{
    /* Write a C# program to check the sum of the two given integers and return true if 
     one of the integer is 20 or if their sum is 20.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor de ingresar el primer entero");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Favor de ingresar el segundo entero");
            int y = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"You entered {x} + {y} " + " the result is " +  checksum(x, y));

        }
        static bool checksum(int a,int b)
        {
            int sum = a + b;
           
            
        if (a==20)
            {

                return true;
            }
            if (b == 20)
                return true;
            if (a + b == 20)
            {

                return true;
            }
            else
                return false;
            

        }
    }
}
