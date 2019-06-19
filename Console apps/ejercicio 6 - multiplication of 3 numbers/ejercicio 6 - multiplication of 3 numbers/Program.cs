using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6___multiplication_of_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el primer multiplicando");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo multiplicando");
           int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer Multiplicando");
            int z = Int32.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la multiplicacion es "+ x * y * z);

        }
    }
}
