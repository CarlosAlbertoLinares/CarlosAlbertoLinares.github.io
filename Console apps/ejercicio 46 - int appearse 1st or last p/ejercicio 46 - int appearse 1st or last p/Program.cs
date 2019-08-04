using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_46___int_appearse_1st_or_last_p
{
    // Write a C# program to check if a number appears as either the first or last element of an array 
    //of integers and the length is 1 or more.

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Especifique el numero de elementos que va a tener el arreglo: ");
            int arraySize = Int32.Parse(Console.ReadLine());

            int[] array = new int[arraySize];

            Console.WriteLine("Especifique los elementos del arreglo en cada posicion del index: ");

            public static Array[] filler (int[] array) 
            {
            int [] array2 = array;

             for (int y = 0; y<array.Length;y++)
            {

                array2[y] = Int32.Parse(Console.ReadLine());
            }
            return array;
}
}

           

         

            Console.WriteLine("Ingrese el numero que quiere filtrar: ");
            int filterNumber = Int32.Parse(Console.ReadLine());
            

            for(int x = 0; x < array.Length; x++)
            {

                if (x == 0 || x == array.Length-1)

                {
                    if (filterNumber == array[x])

                    {

                        Console.WriteLine(true);

                    }

                }

                }


            }

        }
    }

