using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_59___strickly_incrising_sequenc
{
    /* Write a C# program to check whether it is 
    possible to create a strictly increasing sequence 
        from a given sequence of integers as an array.
        En otras palabras que los elementos del arren vayan incrementando y nunca haya decresimiento en la grafica.
        */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsItAnIncreasingArray(new int[] { 1, 3, 1,3 }));
        } 
        static bool IsItAnIncreasingArray(int[] input)
        {
            int count = 0;
            for (int x = 1; x < input.Length; x++)
            {
                if (input[x - 1] > input[x])
                {
                    count++;
                }
            }
            return count != 0 ? false : true;
        }
    }
}
