using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_47___sum_of_elements_on_array
{
    //Write a C# program to compute the sum of all the elements of an array of integers.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa que suma todos los elementos de un array");

            int[] Array = { 1, 2, 3 };

            Console.WriteLine("El resultado de la suma es: " + SumOperator(Array));



        }
        public static int SumOperator (int[] input)
        {
            int sum =0 ;
            for(int x=0;x<input.Length;x++)
            {
                sum = sum + input[x];
                
            }
            return sum;

        }
    }
}
