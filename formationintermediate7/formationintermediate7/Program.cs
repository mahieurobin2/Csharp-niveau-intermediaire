using System;

namespace formationintermediate7
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Robin";
            Console.WriteLine(cookie["name"]);
        }
    }
}
