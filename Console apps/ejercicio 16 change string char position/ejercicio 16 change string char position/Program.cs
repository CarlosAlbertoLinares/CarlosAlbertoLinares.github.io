using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_16_change_string_char_position
{
    // Write a C# program to create a new string from a given string where the first and last characters will change their positions.
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cadena de caracteres en la que el primer elemento será cambiado en posición por el ultimo.");
            string input = Console.ReadLine();

            int firstPosition = (input.Length - input.Length);
            int lastPosition = input.Length;


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[lastPosition - 1])
                {
                    Console.Write(input[firstPosition]);

                }
              
                if (input[i] == input[firstPosition])
                {
                    Console.Write(input[lastPosition - 1]);

                }
                else if (input[i] != input[lastPosition-1] && i != input[firstPosition])
                {

                    Console.Write(input[i]);
                }
                
              
               
                
               



            }
        }

        }
    }

