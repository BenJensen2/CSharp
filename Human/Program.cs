﻿using System;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Dan = new Human("Dan");
            Dan.Love(Dan);
            Console.WriteLine(Dan.Health);
        }
    }
}
