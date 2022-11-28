using System;

namespace Restaurant
{
    class Program
    {
        string name = "abc";
        static void Main(string[] args)
        {
            Program rest = new Program();
            rest.name = "pecos";
            Console.WriteLine(rest.name);
        }
    }
}
