using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7_suma_resta_m_d_de_2_numeros
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Este programa realiza la funcion de una calculadora de enteros simple");
            Console.WriteLine("Favor de ingresar el primer numero");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Favor de ingresar el segundo numero");
            int y = Int32.Parse(Console.ReadLine());

            int resultS = sum.sumando(x, y);
            Console.WriteLine("suma: " + resultS);

            int resultR = subtraction.substracting(x, y);
            Console.WriteLine("Resta: " + resultR);

      int resultM = multiplication.Multiply(x,y);
            Console.WriteLine("multiplicación: " + resultM);

            int resultD = division.dividing(x, y);
            Console.WriteLine("Division: " + division.dividing(x,y));




          
        }
    }
    class sum
    {

        public static int sumando(int a,int b)
        {

            int sumaR = a + b;
            return sumaR;

        }
    }

     class subtraction
    {

        public static int substracting(int a, int b)
        {
            int substractR = a - b;
            return substractR;

        }


    }
   

 class  multiplication 
    {

    public static int Multiply(int a, int b)
            
    {
        

            int RM = a * b;
            return RM;

    }

        


        }
    class division
    {

        public static int dividing(int a, int b)
        {
            int divR = a / b;
            return divR;


        }

    }





}

