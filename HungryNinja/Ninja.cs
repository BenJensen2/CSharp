using System.Collections.Generic;
using System;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja(){
            calorieIntake = 0;
            FoodHistory = new List<Food>(){};
        }
        
        public bool IsFull 
        {
            get{
                if (calorieIntake > 1200){
                    Console.WriteLine("Ninja is full and cannot eat anymore");
                    return true;
                    // string full = "Yes";
                }
                else{
                    return false;
                }
            }
        }

        public void Eat(Food item)
        {
            if (this.IsFull==false)
            {
                string flavor = "";
                this.calorieIntake += item.Calories;
                FoodHistory.Add(item);
                if (item.IsSpicy && item.IsSweet)
                {
                    flavor = "Spicy and Sweet!";
                }
                else if (item.IsSpicy)
                {
                    flavor = "Spicy!";
                }
                else if (item.IsSweet)
                {
                    flavor = "Sweet!";
                }
                else
                {
                    flavor = "Bland";
                }
                Console.WriteLine(item.Name + " is " + flavor);
            }
        }

    }
}