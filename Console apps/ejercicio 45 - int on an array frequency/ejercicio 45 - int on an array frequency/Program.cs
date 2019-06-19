using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_45___int_on_an_array_frequency
{

    //Write a C# program to count a specified number in a given array of integers. Go to the editor
    
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bienvenido al programa que cuenta las ocurrencias de un entero en un array de el mismo tipo.");
            int[] array = { 5, 5, 2, 4, 4, 5, 4, 6 };
            int count = 0;
            Console.WriteLine("Ingrese el numero que desea contar en el array");
            Console.WriteLine("Favor de ingresar el número que quiere contar en el array");
            int[] specificNumber = { Int32.Parse(Console.ReadLine()) } ;

            for (int x5=0; x5 <array.Length; x5++)
            {

                if (array[x5] == specificNumber[0])
                    count++;

            }
            Console.WriteLine(count);

        }
    }
}
