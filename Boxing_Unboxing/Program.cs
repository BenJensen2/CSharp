using System.Collections.Generic;
using System;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> box_List = new List<object> ();
            box_List.Add(7);
            box_List.Add(28);
            box_List.Add(-1);
            box_List.Add(true);
            box_List.Add("chair");
            Console.WriteLine(box_List[0] is string);
            int sum = 0;
            foreach (object box in box_List)
            {   
                if (box is string)
                {
                    string val = (string)box;
                    Console.WriteLine(val);
                }
                if (box is int){
                    int val = (int)box;
                    sum += val;
                    Console.WriteLine(val);
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine("Hello World!");
        }
    }
}
