using System;

namespace Creating_Arrays_of_Values
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // a bucket that contains other buckets 
            // a grouping of data

            // declare by starting with a data type and then
            // declare how large the array will be 

            // can access any item in the array by using its index 

            // arrays use [] 
            // [] --> array or index access operator 

            // "new int[5]" defines the array as having 5 elements
            int[] numbers = new int[5];

            // defining an array of integers 
            // "The numbers array at index one equals the value 8" 
            // arrays are 0 based!!!!!!!
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            // numbers[5] = 42;   ---> outside of the array

            // the length property shows the number of elements in an array 
            Console.WriteLine(numbers.Length);

            /*
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
            
            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
            */


            /*
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            // iterates through the code block once for each element in the array 
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            /*
            string zig = "You can get what you want out of life " +
                "if you help enough other people get what they want.";

            // char can store a single alpha numberic character
            // defining an array of chars 
                // each individual letter of the string will be an element of the char array
            char[] charArray = zig.ToCharArray();
            // it takes each element in the array and reverse its ordinal position 
            Array.Reverse(charArray);

            // iterate through each char in the char array 
            foreach (char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();
            */


        }
    }
}
