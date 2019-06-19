using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_18_check_if_2_given_int_are___
{
    //Write a C# program to check two given integers and return true if one is negative and one is positive.
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("ingrese el valor del primer entero");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del segundo entero");
            b = Int32.Parse(Console.ReadLine());

           bool positive;
           bool negative;
           bool expected;


            if ((a >= 0) && (b >= 0))
            {

                positive = false;
                Console.Write(positive);

            }
         
            
            if ((a <= 0) && (b <= 0))
            {

                negative = false;
                if((a==0)&&(b==0))
                {

                }
                        else
                {

                    Console.Write(negative);
                }
                    

            }
          
            
            if ((a > 0) && (b < 0))
            {

                expected = true;
                Console.Write(expected);

            }
            if ((a<0)&&(b>0))
            {

                expected = true;
                Console.Write(expected);

            }




        }
    }
  
       
}
