using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_40_version_2
{
    //40. Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same
    class Program
    {
        static void Main(string[] args)
        {

            double firstXPoint = Convert.ToDouble(Console.ReadLine());
            double secondXPoint = Convert.ToDouble(Console.ReadLine());

            // double result = Math.Min(Pointdistance(firstXPoint), Pointdistance(secondXPoint));
            // Console.WriteLine(result);
            int cero = 0;
            if (firstXPoint == secondXPoint)
                Console.WriteLine("Como firstXPoint es igual a secondXPoint se retorna: " + cero);

            if(Pointdistance(firstXPoint) < Pointdistance(secondXPoint))
                {
                Console.WriteLine($"El numero mas cercano a 20 entre {firstXPoint} y {secondXPoint} es: {firstXPoint}");
            }
            else
            {

                Console.WriteLine($"El numero mas cercano a 20 entre {firstXPoint} y {secondXPoint} es: {secondXPoint} ");
            }
            

        }

        static double Pointdistance(double inputPoint)

        {
            
            double distance = Math.Sqrt(Math.Pow(20 - inputPoint, 2 ));
            return distance;
        }


    }
}
