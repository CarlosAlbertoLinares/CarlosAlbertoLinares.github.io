 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efercicio_15_remove_a_char_from_string
{
    //Write a C# program remove specified a character from a non-empty string using index of a character.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la palabra a la que se le quiere remover un caracter");
            string input = Console.ReadLine();
           


            Console.WriteLine("Especifique el caracter que quiere eliminar");
            char eliminate = char.Parse(Console.ReadLine());

            foreach (char c in input)
            {



                if (c == eliminate)
                {

                }
                else
                    Console.Write(c);

            }

           

        }
    }
}
