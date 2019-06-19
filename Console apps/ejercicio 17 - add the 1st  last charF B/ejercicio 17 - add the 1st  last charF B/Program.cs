using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17___add_the_1st__last_charF_B
{

    // Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("ingrese el string que tenga 1 caracter o mas");
                input = Console.ReadLine();
                
            } while(input == "");



            int firstCaracter = input.Length - input.Length;
            int firstPosition = input.Length - input.Length;
            int lastPosition = input.Length;

            for (int x = 0; x < input.Length; x++)
            {
                if (input[x] == input[firstCaracter])
                {
                    Console.Write(input[firstCaracter]);
                    if (input.Length != 1)
                    Console.Write(input[firstCaracter]);
                }
                if (input[x] != input[firstPosition] && input[x] != input[lastPosition - 1])
                {

                    Console.Write(input[x]);
                }
                if (input[x] == input[lastPosition-1]  )
                {
                    Console.Write(input[x]);
                    Console.Write(input[firstCaracter]);
                }
              

            }


        }
    }

    



            


    
}



