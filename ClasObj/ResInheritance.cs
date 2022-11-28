using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
    {
    class Pecos
    {
        public string Star = "**";

        public void Chef()
        {
            Console.WriteLine("all the chefs are promising!");
        }
    }
    class Barbeque : Pecos
    {
        public string Address = "Koramangala";
    }
    class ResInheritance
    {
        static void Main(string[] args)
        {
            Barbeque berbeque = new Barbeque();
            berbeque.Chef();
            Console.WriteLine("pecos is " + berbeque.Star + " is located at" + berbeque.Address);

        }
    }
}
