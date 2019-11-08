using System;

namespace IdexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();

            cookie["name"] = "Dan";

            Console.WriteLine(cookie["name"]);
        }
    }
}
