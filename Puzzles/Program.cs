using System;
using System.Collections.Generic;

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

        public static int TossCoin(){
            // Console.WriteLine("Tossing a Coin!");
            Random num = new Random();
            int result = num.Next(1,3);
            // string resultStr = "Neither";
            if (result==1){
                // resultStr = "Heads";
                // Console.WriteLine(resultStr);
            }
            else{
                // resultStr = "Tails";
                // Console.WriteLine(resultStr);
            }
            // Console.WriteLine(result);
            return result;
        }

        public static double TossMultipleCoins(int num){
            int headCount = 0;
            int tailCount = 0;
            for (int val=0; val<num; val++){
                int result = TossCoin();
                if (result==1){
                    headCount ++;
                }
                if (result==2){
                    tailCount ++;
                }      
                Console.WriteLine(headCount + " : " + tailCount + " num: " + num);      
            }
            Console.WriteLine(headCount);
            double ratio = 100*headCount/num;
            Console.WriteLine(ratio + "%");
            return ratio;
        }

        public static List <string> Names()
        {
            string temp = "";
            int rand = 0;
            List <string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            for (int i =1;i < names.Count; i++)
            {
                Random num = new Random();
                rand = num.Next(1,names.Count);
                temp = names[rand];
                names[rand] = names[i];
                names[i] = temp;

                Console.WriteLine("i" + names[i]);
                if (names[i].Length<6)
                {
                    names.Remove(names[i]);
                }
            }

            

            return names;
        }
        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            RandomArray();
            TossCoin();
            TossMultipleCoins(22);
            Names();
        }
    }
}
