using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Buffet trial = new Buffet();
            Console.WriteLine(trial.Serve().Name);
        }
    }
}
