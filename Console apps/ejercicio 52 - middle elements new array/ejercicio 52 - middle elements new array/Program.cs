using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_52___middle_elements_new_array
{
    /*Write a C# program to create a new array of length containing the middle elements of three arrays (each length 3) of integers. Go to the editor
    Test Data:
Array1: [1, 2, 5]
Array2: [0, 3, 8]
Array3: [-1, 0, 2]
New array: [2, 3, 0]
*/

    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 1, 5, 5 };
            int[] array2 = { 0, 3, 8 };
            int[] array3 = { -1, 0, 2 };
            int[] outputArray = ArrayMiddleFilter(array1, array2, array3);
            Console.Write("[ ");
            foreach (int x in outputArray)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
                
        }
        public static int[] ArrayMiddleFilter(int[] x, int[] y, int[] z)
        {

            int[] newArray = { x[1], y[1], z[1] };
            return newArray;
        }
    }
}
