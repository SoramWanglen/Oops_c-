using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
    {
    class Pecos
    {
        public string star = "**";

        public void chef()
        {
            Console.WriteLine("all the chefs are promising!");
        }
    }
    class Barbeque : Pecos
    {
        public string address = "Koramangala";
    }
    class ResInheritance
    {
        static void main(string[] args)
        {
            Barbeque berbeque = new Barbeque();
            berbeque.chef();
            Console.WriteLine("pecos is " + berbeque.star + " is located at" + berbeque.address);

        }
    }
}
