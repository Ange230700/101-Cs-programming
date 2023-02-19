using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHub2
{
    class ArmstrongNumberOrNot
    {
        static void Main(string[] args)
        /*
        Ce programme permet d'identifier les nombres d'Armstrong.
        Qu'est-ce qu'un nombre d'Armstrong. 
        */
        {
            int number, remainder, sum = 0;
            /*
            Manière efficace d'initialiser plusieurs valeurs à zero.
            */
            Console.Write("Enter a Number : ");
            number = int.Parse(Console.ReadLine());

            for (int counter = number ; counter > 0 ; counter = counter / 10)
            /*
            POUR compteur allant de 'NUMBER'(déclaré et initialisé à la ligne 22)
            au premier compris entre 0 et 10 (0 et 10 non inclus) 
            avec un pas de "compteur / 10"
            */
            {
                remainder = counter % 10;
                sum = sum + remainder * remainder * remainder;
            }
            Console.Write("\nLa somme vaut : ");
            Console.WriteLine(sum);
            Console.Write("\nEt le nombre donné est : ");
            Console.WriteLine(number);

            if (sum == number)
            {
                Console.Write("\nEntered Number is an Armstrong Number.\n\n");
            }
            else
            {
                Console.Write("\nEntered Number is not an Armstrong Number.\n\n");
            }
        }
    }
}
