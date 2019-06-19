using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_31_array_respective_multip
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Este programa realiza la multiplicacion de 2 arreglos especificos");
            int[] arrayX = { 1, 2, 3 };
            int[] arrayY = { 4, 5, -6 };

            int length = arrayY.Length;

            int[] result = new int[length];
            

            for (int i = 0;i <length;i++ )
            {
                result[i] = arrayX[i] * arrayY[i];


            }
            for (int z = 0; z < length; z++)
                
                Console.WriteLine(arrayX[z] + " * " + arrayY[z] + " = " + result[z]);
        }
    }
}
