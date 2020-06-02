using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Dan = new Human("Dan");
            Console.WriteLine(Dan.Love(Dan));
        }
    }
}
