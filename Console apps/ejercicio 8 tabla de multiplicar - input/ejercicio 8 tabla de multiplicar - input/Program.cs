using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8_tabla_de_multiplicar___input
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("input an integer(int) to retrive de multiplication table of it : ");
            bool askAgainForInt;
            do
            {
                askAgainForInt = false;
                try
                {
                    int number = Int32.Parse(Console.ReadLine());
                    for (int x = 0; x < 11; x++)
                    {
                        int outputnumber = number * x;
                        Console.WriteLine(outputnumber);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Your input is not numeric or int");
                    Console.WriteLine("Please try again: ");
                    askAgainForInt = true;
                }
            } while (askAgainForInt == true);



        }





    }
}
