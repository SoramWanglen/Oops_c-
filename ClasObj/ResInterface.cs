using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public interface IBarbequeNation
    {
        public void FoodReview();
    }
    class FoodNation
    {
        public void FoodReview()
        {
            Console.WriteLine("They serve amazing foods!");
        }
    }
    class ResInterface
    {
        static void Main(string[] args)
        {
            FoodNation myFood = new FoodNation();
            myFood.FoodReview();
        }
    }
}
