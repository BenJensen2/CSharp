using System;
namespace Dojodachi.Models
{
    public class Chi
    {
        public int Happiness;
        public int Fullness;
        public int Energy;
        public int Meals;

        public Chi()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
        }

        public void Feed()
        {
            Console.WriteLine("\nFeeding\n");
            // if(this.Meals>0)
            // {
            //     this.Meals -= 1;
            //     Random num = new Random();
            //     this.Fullness += num.Next(5,11);
            // }
            // else
            // {
            //     Console.WriteLine("You do not have enough meals.  Work to gain more");
            // }

        }
    }
}