using System;

namespace Basic13
{
    class Program
    {

        public static void PrintNumbers()
        {
            for(int val = 1; val<256; val++)
            {
            Console.WriteLine(val);

            }
                // Print all of the integers from 1 to 255.
        }
        public static void PrintOdds()
        {
            for(int val = 1; val<256; val= val + 2)
            {
            Console.WriteLine(val);

            }
            // Print all of the odd integers from 1 to 255.
        }

        public static void PrintSum()
        {
            int sum = 0;
            for(int val = 0; val<256; val++)
            {
                sum = sum + val;
                Console.WriteLine("New number:" + val + "  Sum:" + sum);

            }// Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
        }

        public static void LoopArray(int[] numbers)
        {
            for(int val = 0; val<numbers.Length; val++)
            {
                Console.WriteLine(numbers[val]);

            }
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for(int val = 0; val<numbers.Length; val++)
            {
                if(numbers[val]>max)
                {
                    max = numbers[val];

                }
            }
            Console.WriteLine(max);
            return max;
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for(int val = 0; val<numbers.Length; val++)
            {
                sum = sum + numbers[val];
                // Console.WriteLine(sum);
            };
            int avg = sum/numbers.Length;
            Console.WriteLine(avg);
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
        }

        public static int[] OddArray()
        {
            int[] array = new int[128];
            int val = 1;
            int num = 0;
            while (val < 256){
                array[num]=val;
                val = val +2;
                num ++;
            }
            Console.WriteLine(array[0]);
            Console.WriteLine(array[126]);
            return array;
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
            // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for(int val = 0; val<numbers.Length; val++)
            {
                if(numbers[val]>y)
                {
                    count++;

                }
            }
            Console.WriteLine(count);
            return count;
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
        }

        public static void SquareArrayValues(int[] numbers)
        {
            int [] square = new int[numbers.Length];

            for(int val = 0; val<numbers.Length; val++)
            {
                square[val] = numbers[val] * numbers[val];

            };
            Console.WriteLine(square[6]);
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for(int val = 0; val<numbers.Length; val++)
            {
                if(numbers[val]<0){
                    numbers[val] = 0;
                }

            };
            Console.WriteLine(numbers[7]);
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = numbers[0];
            int avg = 0;
            for(int val = 0; val<numbers.Length; val++)
            {
                if(numbers[val]>max)
                {
                    max = numbers[val];
                }
                if(numbers[val]<min)
                {
                    min = numbers[val];
                }
                sum = sum + numbers[val];
                // Console.WriteLine(sum);
                avg = sum/numbers.Length;
            }
            Console.WriteLine("Max: " + max + " Min " + min + " Avg: " + avg);
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
        }

        public static void ShiftValues(int[] numbers)
        {
            int[] array = new int[numbers.Length];
            for(int val = 0; val <numbers.Length-1; val++)
            {
                array[val] = numbers[val+1];
            }
            array[numbers.Length-1]=0;
            Console.WriteLine("[{0}]", string.Join(", ", array));

            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] array = new object [numbers.Length];
            for (int i=0; i<numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    array[i] = "Dojo";
                    
                }
                else
                {
                    array[i] = numbers[i];
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
            return array;
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        }

        static void Main(string[] args)
        {

            
            Console.WriteLine("Hello World!");
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            int [] numbers = {-10,2,0,4,-5,6,22,-8,9,10};
            // LoopArray(numbers);
            // FindMax(numbers);
            // GetAverage(numbers);
            // OddArray();
            // GreaterThanY(numbers,-9);
            // SquareArrayValues(numbers);
            // EliminateNegatives(numbers);
            // MinMaxAverage(numbers);
            // ShiftValues(numbers);
            NumToString(numbers);

        }
    }
}
