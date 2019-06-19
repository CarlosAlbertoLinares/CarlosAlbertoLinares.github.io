using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_41___w_char_between_1_and_3time
{
    //Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times.
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int length = input.Length;
            int iteratorW = 0;

            for (int x = 0; x < length; x++)
            {
                if (input[x]=='w')
                {

                    iteratorW++;
                    

                }
                


            }
            if (iteratorW <= 3 && iteratorW>0)
            {
                Console.WriteLine("Contiene el char w entre 1 y 3 veces ");
            }
            else
            {


                Console.WriteLine("No contiene el char w entre 1 y 3 veces");
            }
                


        }
    }
}
