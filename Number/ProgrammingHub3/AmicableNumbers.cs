using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHub3
{
    class AmicableNumbers
    {
        public static void Main(string[] args)
        {
            int num1, num2, sum1 = 0, sum2 = 0, counter;
            Console.Write("Enter first number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            num2 = int.Parse(Console.ReadLine());
            for (counter = 1 ; counter < num1 ; counter++)
            {
                if (num1 % counter == 0)
                {
                    sum1 = sum1 + counter;
                }
            }
            for (counter = 1 ; counter < num2 ; counter++)
            {
                if (num2 % counter == 0)
                {
                    sum2 = sum2 + counter;
                }
            }
            
            if (num1 == sum2 && num2 == sum1)
            {
                Console.WriteLine("They are a pair of Amicable Numbers.");
            }
            else
            {
                    Console.WriteLine("They are not Amicable Numbers.");
            }           
        }
    }
}
