using System;

namespace formationintermediate16
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            circle.Draw();
        }
    }
}
