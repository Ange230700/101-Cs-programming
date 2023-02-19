/*
It's a program which permits to create an array of a chosen size
 */

using System;
/*
System is a namespace which contains fundamental classes that define commonly used value and
references data types, events and event handlers, interfaces, attributes 
and processing exceptions.
 */
using System.Collections.Generic;
/*
It is a namespace which contains interfaces and classes that define generic
collections, which allow users to create strongly typed collections that
provide better type safety and performance than non-generic strongly typed 
collections.
 */
using System.Linq;
/*
 language-integrated query (linq) is the name for a set of technologies based
on the integration of query capabilities directly into the C sharp language.
 */
using System.Text;
/*
It is a namespace which Contains classes that represent ASCII and Unicode 
character encodings; abstract base classes for converting blocks of 
characters to and from blocks of bytes; and a helper class that manipulates 
and formats String objects without creating intermediate instances of String.
 */
using System.Threading.Tasks;
/*
it is namespace which Provides types that simplify the work of writing 
concurrent and asynchronous code.
 */

namespace ProgrammingHub1
{
    class MaxAndMin
    {
        public static void Main()
        {
            int n;
            float large, small;
            int[] a ;

            Console.Write("Enter the size of Array : ");
            string s = Console.ReadLine();

            n = Int32.Parse(s);
            /*
They're converting the string s into an 32-bit integer.
             */
            a = new int[n];
            /*
a new array creation of size n.
             */

            Console.WriteLine("Enter the array elements");

            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
/*
On convertit les caracteres rentres en 32-bit integer
 */

            Console.Write("");

            large = a[0];
            small = a[0];

            for (int i = 1; i < n; i++)
            {
                if (a[i] > large)
                    large = a[i];
                else if (a[i] < small)
                    small = a[i];
            }

/*
on parcourt les elements du premier au dernier pour determiner le larger
et le smaller.
 */

            Console.WriteLine("Largest element in the array is {0}", large);
            Console.WriteLine("Smallest element in the array is {0}", small);
/*
The {0} means to insert the first parameter following the format string; 
in this case the value associated with the key "rtf".
 */
            Console.Read();

        }
    }
}