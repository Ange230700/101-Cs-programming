/*
Ce programme nous permet de trier une liste 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHub4
{
    class SortList1
    {
        public static void Main()
        {
            List<string> names = new List<string>();
/*
Représente une liste fortement typée d'objets accessibles par index. 
Fournit des méthodes de recherche, de tri et de manipulation de listes. 
 */
            names.Add("Ram");
            names.Add("Rose");
            names.Add("Abs");
            names.Add("Edward");
            names.Add("Sita");

            Console.WriteLine("Array without sorting..");

            foreach (string s in names)
/*
The foreach statement: enumerates the elements of a collection and executes 
its body for each element of the collection. 
 */
                Console.WriteLine(s);
            names.Sort();
/*
tri par ordre alphabetique 
 */

            Console.WriteLine("\nArray after sorting..");
            foreach (string s in names)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}