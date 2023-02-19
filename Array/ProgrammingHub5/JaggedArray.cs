using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
A jagged array is an array whose elements are arrays, possibly of different sizes. 
A jagged array is sometimes called an "array of arrays."
 */

namespace ProgrammingHub
{
    class JaggedArray
    {
        static void Main()
        {
            // Declare the array of two elements: 
            int[][] jaggedarr = new int[2][];

            /*
declaration d'un tableau 2D. tout ce qui faut retenir ici, c'est que de 
l'espace a été alloué pour le tableau.
             */

            // Initialize the elements:
            jaggedarr[0] = new int[4] { 1, 3, 7, 9 };
            jaggedarr[1] = new int[5] { 2, 4, 6, 8,7};

            System.Console.WriteLine("Taille de l'array : {0}", jaggedarr.Length);
            System.Console.WriteLine("press a key to keep debugging");
            System.Console.ReadKey();

            // Display the array elements: 
            for (int i = 0; i < jaggedarr.Length; i++)
            {
                System.Console.WriteLine("taille du tableau-element {0} vaut {1}", i, jaggedarr[i].Length);
                System.Console.WriteLine("press a key to keep debugging");
                System.Console.ReadKey();
                System.Console.Write("tableau-element({0}): ", i);

                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", jaggedarr[i][j], j == (jaggedarr[i].Length - 1) ? "" : " ");
                    /*
the conditionnal operator
condition ? result_if_true : result_if_false
Dans ce cas precis, si la proposition est fausse, on met un espace pour l'element suivant
Write permet d'ecrire dans la console sans aller a la ligne.
                     */
                }
                System.Console.WriteLine();
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("press a key to quit");
            System.Console.ReadKey();
        }
    }
}