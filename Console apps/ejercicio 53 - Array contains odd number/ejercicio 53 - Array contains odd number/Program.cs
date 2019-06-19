using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_53___Array_contains_odd_number
{
    /*
     Write a C# program to check if an array contains an odd number. Go to the editor
Test Data:
Original array: [2, 4, 7, 8, 6]
Check if an array contains an odd number? True 
*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa que idenfifica si un array contiene un numero impar entre sus elementos");

            int[] originalArray = { 2, 4, 7, 8, 6 };
            Console.WriteLine("Contiene un numero impar?" + OddVerifier(originalArray));
        }
        public static bool OddVerifier(int[] input)
        {
            int oddCounter = 0;
            foreach(int x in input)
            {
                if(x%2 != 0)
                {
                    oddCounter++;

                }
                if (oddCounter >= 1)
                {
                    return true;
                }

            }
            return false;


        }
    }
}
