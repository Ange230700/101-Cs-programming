using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHub7
{
    class FactorialOfNumber
    {
        static void Main(string[] args)
        {
            int i, number, fact;
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1 ; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is : " + fact);
        }
    }
}
