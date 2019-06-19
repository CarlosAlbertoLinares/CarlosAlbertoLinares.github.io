using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_39___Largest_and_lowest_int
{
    //  Write a C# program to find the largest and lowest values from three integer values.
    class Program
    {



        static int MinArrayInt(int[] array2)
        {
            if (array2 == null)
                throw new ArgumentNullException("array2");
            if (array2.Length == 0)
                Console.WriteLine("El size del array no es valido");

            int firstComparation = Math.Min(array2[0], array2[1]);
            int secondComparation = Math.Min(array2[1], array2[2]);
            int result = Math.Min(firstComparation, secondComparation);
            return result;


        }
         static int MaxArrayInt(int[] array)
        {

            if (array == null)
                throw new ArgumentNullException("array");

            if (array.Length == 0)
                Console.WriteLine("El size del array no puede ser cero");



           int firstComparation =  Math.Max(array[0], array[1]);
            int secondComparation = Math.Max(array[1], array[2]);
            int result = Math.Max(firstComparation, secondComparation);
            return result;



            }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer entero");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo entero");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer entero");
            int c = Int32.Parse(Console.ReadLine());

            int[] inputArray = { a, b, c };


            int resultMayor = MaxArrayInt(inputArray);
            int resultMenor = MinArrayInt(inputArray);

            Console.WriteLine($"El mayor numero entre {a},{b},{c} es: " + resultMayor);
            Console.WriteLine($"El numero menor entre {a},{b},{c} es :" + resultMenor);

        }

    

        

    }
        

    }


