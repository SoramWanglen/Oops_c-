using System;

namespace Restaurant
{
    class ResClaObj
    {
        string name = "abc";
        static void Main(string[] args)
        {
            ResClaObj rest = new ResClaObj();
            rest.name = "pecos";
            Console.WriteLine(rest.name);
        }
    }
}
