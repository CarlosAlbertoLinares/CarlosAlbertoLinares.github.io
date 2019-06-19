using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_27___sum_of_digits_of_an_int3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int sumando = 0;
            Console.WriteLine("Favor de ingresar el número entero en el que cada uno de sus digitos será sumado");
            string input = Console.ReadLine();
            foreach(char c in input)
            {

                //WriteLine(c);
             

                int acumulado = Convert.ToInt32(new String(c,1));
               sumando = acumulado + sumando;
                



            }
            Console.WriteLine(sumando);
        }
    }
}
