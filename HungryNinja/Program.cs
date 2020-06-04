using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet buffet = new Buffet();
            // Console.WriteLine(trial.Serve().Name);
            Ninja Tommy = new Ninja();
            while (!Tommy.IsFull)
            {
                Tommy.Eat(buffet.Serve());
            }

        }
    }
}
