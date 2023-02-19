using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHub3
{
    class Program
    {
        public static void Main()
        {
            int[] arrayA = new int[5];
            int lengthA = arrayA.Length;
            Console.WriteLine("Length of Array : {0}", lengthA);
            /*
creation tableau de 5 entiers
affectation taille tableau
             */

            long longLength = arrayA.LongLength;
            Console.WriteLine("Length of the LongLength Array  : {0}", longLength);

            int[,] twoD = new int[5, 10];
            Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);
/*
Il faut comprendre que pour tableau 2d, la taille est la multiplication des
2 dimensions.
 */
            Console.ReadLine();
/*
Reads the next line of characters from the standard input stream.
ca empeche de sortir du programme sans avoir appuyé sur une touche.
Ou bien ca bloque le programme a un certain niveau.
 */
        }
    }
}