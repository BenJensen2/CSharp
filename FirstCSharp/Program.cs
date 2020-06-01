// *For this course, be sure to zip and upload the entire project folder together*
//  Create a Loop that prints all values from 1-255
//  Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
//  Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
//  (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!


using System;

// namespace FirstCSharp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             for(int val = 1; val<256; val++)
//             {
//             Console.WriteLine(val);

//             }
//         }
//     }
// }

// namespace FirstCSharp
// {
//     class Count
//     {
//         static void Main(string[] args)
//         {
//             for(int val = 1; val<101; val++)
//             {
//                 if(val%3==0 && val%5 ==0){
//                     Console.WriteLine("FizzBuzz");
//                 }

//                 if(val%3 == 0){
//                     Console.WriteLine("Fizz");
//                 }

//                 if(val%5 == 0){
//                     Console.WriteLine("Buzz");
//                 }

//             }
//         }
//     }
// }

namespace FirstCSharp
{
    class Count
    {
        static void Main(string[] args)
        {
            int val = 1;
            while(val<101)
            {
                val ++;
                if(val%3==0 && val%5 ==0){
                    Console.WriteLine("FizzBuzz");
                }

                if(val%3 == 0){
                    Console.WriteLine("Fizz");
                }

                if(val%5 == 0){
                    Console.WriteLine("Buzz");
                }

            }
        }
    }
}