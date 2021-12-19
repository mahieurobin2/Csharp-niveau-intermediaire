using System;
using System.Collections.Generic;

namespace formationintermediate12
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Text text = new Text();
        //    Shape shape = text;

        //    text.Width = 200;
        //    shape.Width = 100;

        //    Console.WriteLine(text.Width);
        // }

        // StreamReader reader = new StreamReader(new MemoryStream());
        Shape shape = new Text();
        Text text = (Text) shape;
    }
}
