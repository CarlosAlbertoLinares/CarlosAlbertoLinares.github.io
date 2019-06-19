using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_13_covert_From_Celsius_to_K_F
{
    public class UnitConverter
    {
        double factor;
        public UnitConverter(double unitRatio) { factor = unitRatio; }
        public double ConvertK(double unit) { return (unit + factor); }
        public double ConvertF(double unit) { return (unit * 9 / 5) + factor; }


        class Program
        {
            static void Main(string[] args)
            {
                UnitConverter CelsiusToKelvin = new UnitConverter(273.15d);
                UnitConverter CelsiusToFahrenheit = new UnitConverter(32);

                Console.WriteLine("Ingrese la cantidad en Celsius que desea convertir a K y F");
                Double Celsius = Double.Parse(Console.ReadLine() );
                Console.WriteLine($"\n{Celsius} grados Celsius en Kelvin y Fahrenheit son:");


                Console.WriteLine("Kelvin: " + CelsiusToKelvin.ConvertK(Celsius));
                Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit.ConvertF(Celsius));






            }
        }
    }
}
