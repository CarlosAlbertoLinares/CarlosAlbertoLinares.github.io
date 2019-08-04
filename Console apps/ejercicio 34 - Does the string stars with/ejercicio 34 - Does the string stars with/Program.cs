using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_34___Does_the_string_stars_with
{

    /*
Write a C# program to check if a string starts with a specified word. Go to the editor
Note: Suppose the sentence starts with "Hello"
Sample Data: string1 = "Hello how are you?"
Result: Hello.
Sample Output:
Input a string : Hello how are you? 
True 
*/


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese la palabra a filtrar en el string(oracion)");
            string word = Console.ReadLine();


            Console.WriteLine("Ingrese el string");
            string input = Console.ReadLine();

            string[] split = input.Split(' ');

            foreach(string s in split)
            {
                if(s != " ")
                {
                    Console.WriteLine(s);
                    if (s == word)
                    {
                        Console.WriteLine(true);
                        break;

                    }
                        
                    else
                    {
                        Console.WriteLine(false);
                        break;

                    }
                       
                    


                }

            }

            








        }
    }
}
