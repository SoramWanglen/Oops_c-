using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Restaurant
    {
        private string restaurantName;
        private int restaurantAge;

        public string Name
        {
            get
            {
                return restaurantName;
            }
            set
            {
                restaurantName = value;
            }
        }
        public int Age
        {
            get
            {
                return restaurantAge;
            }
            set
            {
                restaurantAge = value;
            }
        }
    }
   
    class ResEncapsulation
    {
        static public void Main(string[] args)
        {
            Restaurant myRestaurant = new Restaurant();
            myRestaurant.Name = "Toi Indiranagar";
            myRestaurant.Age = 15;

            Console.WriteLine("name of restaurant: " + myRestaurant.Name);
            Console.WriteLine("Age of restaurant: " + myRestaurant.Age);
        }
    }
}
