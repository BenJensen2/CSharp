// Three Basic Arrays
// Create an array to hold integer values 0 through 9
// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
// Create an array of length 10 that alternates between true and false values, starting with true
// List of Flavors
// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
// Output the length of this list after building it
// Output the third flavor in the list, then remove this value
// Output the new length of the list (It should just be one fewer!)
// User Info Dictionary
// Create a dictionary that will store both string keys as well as string values
// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly select a flavor from your flavors list.
// Loop through the dictionary and print out each user's name and their associated ice cream flavor

using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {1,2,3,4,5,6,7,8,9};
            string[] nameArray = new string [] {"Tim", "Martin", "Nikki","Sara"};
            string[] boolArray = new string [] {"true", "false", "true","false", "true","false", "true","false", "true","false"};
            List<string> iceCream = new List<string> ();
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Peanut Butter");
            iceCream.Add("Cookies And Cream");
            iceCream.Add("Tart Lime");
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.Remove(iceCream[2]);
            Console.WriteLine(iceCream.Count);
            Dictionary<string,string> Arrays = new Dictionary<string, string>();
            Random num = new Random();
            Arrays.Add("numArray",$"{numArray[num.Next(0,8)]}");
            Random name = new Random();
            Arrays.Add("nameArray",$"{nameArray[name.Next(0,3)]}");
            Random booly = new Random();
            Arrays.Add("boolArray",$"{boolArray[booly.Next(0,3)]}");
            Random iceCreamy = new Random();
            Arrays.Add("iceCream",$"{iceCream[iceCreamy.Next(0,3)]}");
            foreach (KeyValuePair<string,string> entry in Arrays)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
