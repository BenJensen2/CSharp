using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Beef", 200, true, false),
                new Food("Cherries", 100, false, true),
                new Food("Apples", 100, false, true),
                new Food("Oranges", 200, false, true),
                new Food("Jalapeno", 10, true, false),
                new Food("Egg", 50, false, false),
                new Food("Chorizo", 100, true, false)
            };
        }

        public Food Serve()
        {
            Random num = new Random();
            int result = num.Next(0,7);
            return Menu[result];
        }
        

    }
}