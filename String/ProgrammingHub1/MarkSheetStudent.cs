using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHub1
{

    class MarkSheetStudent
    {
        public static void Main(string[] args)
        {
            int r, m1, m2, m3, t;
            float p;
            string n;
            Console.Write("Enter Roll Number : ");
            r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name : ");
            n = Console.ReadLine();
            Console.Write("Mark of Maths : ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark of Science : ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mark of Grammar : ");
            m3 = Convert.ToInt32(Console.ReadLine());
            t = m1 + m2 + m3;
            p = t / 3.0f;
            Console.WriteLine("Total : " + t);
            Console.WriteLine("Percentage : " + p);
            if (p >= 35 && p < 50)
            {
                Console.WriteLine("Grade is C");
            }
            if (p >= 50 && p <= 60)
            {
                Console.WriteLine("Grade is B");
            }
            if (p > 60 && p <= 80)
            {
                Console.WriteLine("Grade is A");
            }
            if (p > 80 && p <= 100)
            {
                Console.WriteLine("Grade is A+");
            }
            Console.ReadLine();
        }
    }
}