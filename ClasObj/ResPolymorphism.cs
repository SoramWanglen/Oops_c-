using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Pecoss
    {
        public virtual void StarRating()
        {
            Console.WriteLine("This is a *** restaurant");
        } 
    }
    class BerbequeNation : Pecoss
    {
        public override void StarRating()
        {
            Console.WriteLine("This is a **** restaurant");

        }
    }
    class IndiranagarSocial : Pecoss
    {
        public override void StarRating()
        {
            Console.WriteLine("This is a ***** restaurant");
        }
    }
    class ResPolymorphism
    {
        static void Main(String[] args)
        {
            Pecoss myPecoss = new Pecoss();
            Pecoss myBerbequeNation = new BerbequeNation();
            Pecoss myIndiranagarSocial = new IndiranagarSocial();

            myPecoss.StarRating();
            myBerbequeNation.StarRating();
            myIndiranagarSocial.StarRating();
        }
    }
}
