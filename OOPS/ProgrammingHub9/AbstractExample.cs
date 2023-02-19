using System;

namespace ProgrammingHub9
{
    public abstract class Shape
    {
        public abstract void draw();
    }

    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }

    class Triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Draw Triangle");
        }
    }

    class AbstractExample
    {
        public static void Main()
        {
            Shape Forme1 = new Rectangle();

            Forme1.draw();
            Forme1 = new Triangle();
            Forme1.draw();

            Console.ReadKey();
        }
    }
}