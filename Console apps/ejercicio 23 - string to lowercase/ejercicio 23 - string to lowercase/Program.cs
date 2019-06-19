using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_23___string_to_lowercase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor de ingresar el string que sera presentado en minúsculas: ");
            string input = Console.ReadLine();
            string lowerOutput= input.ToLower();
            Console.Write(lowerOutput);
        }
    }
}
