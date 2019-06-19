using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_19_sum_of_input_int_triple_if
{

    //Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor de ingresar el primer número entero");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Favor de ingresar el segundo número entero");
            int y = Int32.Parse(Console.ReadLine());
            
            Console.Write(operate(x, y));


        }

        static int operate(int a, int b)
        {
            if (a != b)
            {

                int sum = a + b;
                return sum;
                

            }
            else
            {
                int triple = (a + b) * 3;
                return triple;
            }
            
          
        }
        
     

    }
}
 

