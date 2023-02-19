/*
Ce programme fait des operations arithmetiques avec deux nombres entres par
le user.
 */

using System;

// the using keyword allows us not to write the whole name while calling
// on a method, each time.
// I feel like they always begin by that.

namespace ProgrammingHub
// a namespace contains classes.
{
    class ArithmeticOperations
//declaration of a class
    {
        static void Main(string[] args)
/*
 static keyword makes the event available to callers at any time, 
even if no instance of the class exists.

void keyword represnts the absence of a type. It is used as the return type
of a method that doesn't return a value.

reminder of Main method needed ? reminder of args needed too

 */
        {
            
            Console.WriteLine(true);
            Console.WriteLine("Appuyer une touche pour continuer le programme.");
            Console.ReadLine();
            Console.WriteLine("Enter two numbers : ");
//inputs data in the console

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
//Convert is a class which is converting one data type to another
//which is a 32-bit signed integer.
//ReadLine is a method which reads data entered in the console

            Console.WriteLine("\nSum : " + (a + b));
            Console.WriteLine("Difference : " + (a - b));
            Console.WriteLine("Product : " + (a * b));
            Console.WriteLine("Quotient : " + (a / b));
            Console.WriteLine("Integer Quotient : " + (a / b));
            Console.WriteLine("Remainder : " + (a % b));
            Console.WriteLine("Exponent : " + Math.Pow(a, b));
/*
 La concatenation est faite avec +
 */

            Console.Read();
        }
    }
}