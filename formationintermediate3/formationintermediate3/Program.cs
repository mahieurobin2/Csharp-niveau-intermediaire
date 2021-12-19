using System;

namespace formationintermediate3
{

    class Program
    {
        static void Main(string[] args)
        {
            var Calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

            static void UsePoints()
            {
                try
                {
                    var point = new Point(10, 20);
                    point.Move(null);
                    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                    point.Move(100, 200);
                    Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                }
                catch (Exception)
                {
                    Console.WriteLine("An unexpected error occured.");
                }
            }
        }
    }
}
