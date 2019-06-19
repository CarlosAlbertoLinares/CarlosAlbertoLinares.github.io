using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_swap_2_number
{

    /*Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output: 
After Swapping :
First Number : 6 
Second Number : 5 

 */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program that swaps 2 numbers \n");
            Console.WriteLine("El primer numero es");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("El segundo numero es");
            int b = Int32.Parse(Console.ReadLine());


            int placeholder = 0;

            placeholder = a;
            a = b;
            b = placeholder;

            Console.WriteLine("El primer numero es: " +Convert.ToString(a));
                Console.WriteLine("El segundo numero es: " + Convert.ToString(b));
            
        }
    }
 

    }

