using System;

namespace ProgrammingHub4
{
    class CelsiusToFahrenheit
    { 
        public static void Main()
        {
            double centigrade;
            double fahrenheit;

            Console.Write("Enter temperature in centigrade : ");
            centigrade = Convert.ToDouble(Console.ReadLine());

            fahrenheit = 1.8 * centigrade + 32;
            Console.WriteLine("\nTemperature in Fahrenheit : {0}", fahrenheit);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}