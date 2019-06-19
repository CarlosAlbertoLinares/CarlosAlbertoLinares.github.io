using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejercicio_29___find_the_size_of_a_fila
{
    // Write a C# program to find the size of a specified file in bytes.
    class Program
    {
        static void Main(string[] args)
        {


            FileInfo bytes = new FileInfo(@"C:\Users\Carlos\Desktop\status.txt");
            Console.Write("The size of the file is: " + bytes.Length + " bytes");
        }
    }
}
