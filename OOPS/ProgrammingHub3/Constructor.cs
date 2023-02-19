using System;

namespace ProgrammingHub3

{
    class Constructor
    {
        private int val;

        public Demo()
        {
            Console.WriteLine("Inside Constructor");
            val = 42;
        }

        public int Value()
        {
            Console.WriteLine("\nInside Value function");
            return val * 20;
        }
    }

    static class Module1
    {
        public static void Main()
        {
            Demo x = new Demo();
            Console.WriteLine("\nReturn value by Value function : " + x.Value());
            Console.Read();
        }
    }
}