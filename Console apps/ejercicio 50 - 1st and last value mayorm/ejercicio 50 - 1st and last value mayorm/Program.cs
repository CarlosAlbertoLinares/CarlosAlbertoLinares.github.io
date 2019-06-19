using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_50___1st_and_last_value_mayorm
{
    /*Write a C# program to rotate an array (length 3) of integers in left direction. Go to the editor
    Test Data:
Array1: [1, 2, 8]
    After rotating array becomes: [2, 8, 1]
    que  cada uno se mueva a la izquierda un ligar
    */

    class Program
    {

        static void Main(string[] args)
        {


            int[] array1 = { 1, 2, 8 };
            int[] array2 = new int[array1.Length];

            for (int x = 2; x >= 0; x--)
            {
                if (x == 2)
                {
                    array2[x] = array1[0];
                }
                else

                    array2[x] = array1[x + 1];

            }
            Console.Write("[ ");
            foreach (int o in array2)
                {
                
                Console.Write(o +" ");
               

            }
            Console.Write("]");



        }
    }
}
