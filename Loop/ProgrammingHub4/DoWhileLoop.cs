using System;

namespace ProgrammingHub4
{
    class DoWhileLoop
    {
        static void Main(string[] args)
        {
            int x = 1;
            do
            {
                Console.WriteLine("value of x : " + x);
                x++;
            } while (x < 10);

            Console.ReadLine();
        }
    }
}