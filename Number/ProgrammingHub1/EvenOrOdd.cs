using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Je dois me renseigner sur toutes les bibliothèques
incluses. 
*/

namespace ProgrammingHub1
/*
Chaque fois que je crée un projet, son nom est
celui du 'NAMESPACE'
*/
{
    class EvenOrOdd
    /*
    Pour le moment, je ne sais pas ce qu'est une classe.
    */
    {
        static void Main(string[] args)
        {
            int EntierDontOnChercheLaParite;
            Console.Write("Enter a number : ");
            EntierDontOnChercheLaParite = int.Parse(Console.ReadLine());

            if (EntierDontOnChercheLaParite % 2 == 0)
            {
                Console.Write(EntierDontOnChercheLaParite + " is an Even Number.");
            }
            else
            {
                Console.Write(EntierDontOnChercheLaParite + " is an Odd Number.");
            }
        }
    }
}