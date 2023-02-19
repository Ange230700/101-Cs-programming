using System;

namespace ProgrammingHub6
{
    class AreaCircumferenceCircle
    {
        public static void Main()
        {
            double area;
            double circumference;
            double radius;

            Console.Write("Enter radius of circle : ");
            radius = Convert.ToDouble(Console.ReadLine());

            area = 3.14 * radius * radius;
            Console.WriteLine("\nArea of Circle is {0}", area);

            circumference = 2 * 3.14 * radius;
            Console.WriteLine("\nCircumference of Circle is {0}", circumference);

            //This line is to hold the output screen
            Console.Read();

        }
    }
}