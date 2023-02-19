using System;

namespace ProgrammingHub5
{
    class DisariumNumber
    {
        public void show(int n)
        {
            int c = 1, rev, sum, x;
            x = n;
            sum = 0;
            rev = 0;

            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n = n / 10;
            }

            while (rev > 0)
            {
                sum = sum + (int) Math.Pow(rev % 10, c);
                c++;
                /*
                Pendant que je copiais le programme, j'ai oublié
                de faire l'incrémentation. Pourtant, c'est ça qui fait
                marcher le truc.
                */
                rev = rev / 10;
            }
            Console.WriteLine("La somme vaut : " + sum);
            Console.WriteLine("X vaut : " + x);
            if (sum == x)
            {
                Console.WriteLine("\n" + x + " is DISARIUM number.");
            }
            else
            {
                Console.WriteLine("\n" + x + " is not DISARIUM number.");
            }
        }
       public static void Main()
        {
            Console.Write("Enter number to check its DISARIUM no. or not : ");
            DisariumNumber ob = new DisariumNumber();
            ob.show(int.Parse(Console.ReadLine()));
        }
    }
}
