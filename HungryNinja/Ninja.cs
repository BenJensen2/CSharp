using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public bool isFull 
        {
            get{return result};
        }
        public Ninja(){
            calorieIntake = 0;
            FoodHistory = new List<Food>(){};
        }
        
    }
}