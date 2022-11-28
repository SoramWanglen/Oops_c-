using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    abstract class Fenny{
        public abstract void Employee();
        public void Show()
        {
            Console.WriteLine("Runs 24/7 !");
        }
    }
    class Fenny2:Fenny
    {
        public override void Employee()
        {
            Console.WriteLine("It has 20 employees");
        }
    }
    class ResAbstraction
    {
        static void Main(string[] args)
        {
            Fenny2 myFenny = new Fenny2();
            myFenny.Employee();
            myFenny.Show();
        }
    }
}
