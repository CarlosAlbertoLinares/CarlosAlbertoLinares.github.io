using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_51___biger_1st_or_last_element
{

    /*Write a C# program to get the larger value between first and last element of an array 
    (length 3) of integers. Go to the editor
    Test Data:
Array1: [1, 2, 5, 7, 8]
*/

    class Program
    {
       

        static void Main(string[] args)
        {

            int[] array = { 4, 2, 5, 7, 2 };
            Console.WriteLine(Comparator(array));


        }
        public static string Comparator(int[] input)

        {
            int[] tempArray = input;

            if (tempArray[0] > tempArray[tempArray.Length - 1])
                return tempArray[0].ToString();
            else if (tempArray[0] < tempArray[tempArray.Length-1])
                return tempArray[tempArray.Length - 1].ToString();
            else
                return "son iguales";
            
          

        }
    }
}
