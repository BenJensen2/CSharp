using System;

namespace Puzzles
{
    class Program
    {
        public static void RandomArray()
        {
            int [] numArray = new int [10];
            int max = 5;
            int min = 25;
            int sum = 0;
            for (int val = 0; val<10; val ++){
                Random num = new Random();
                numArray[val] = num.Next(5,25);
                if(numArray[val]>max)
                {
                    max = numArray[val];
                }
                if(numArray[val]<min)
                {
                    min = numArray[val];
                }
                sum = sum + numArray[val];
            }
            Console.WriteLine("Max: " + max + " Min " + min + " Sum: " + sum);
        }
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            RandomArray();
        }
    }
}
