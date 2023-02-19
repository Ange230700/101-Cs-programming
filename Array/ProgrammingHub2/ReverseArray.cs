/*
this program aims to reverse the elements of an array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHub2
{
    class ReverseArray
    {
        public static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original Array : ");

            foreach (int a in array)
                Console.WriteLine(a);

            Array.Reverse(array);
/*
it exists a method to reverse an array.
 */

            Console.WriteLine("Reversed Array : ");

            foreach (int value in array)
                Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}