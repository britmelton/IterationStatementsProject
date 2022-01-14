﻿using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
            var numbers = new List<int>(); //Create a List called "numbers" - DONE!

            //-----START HERE------------------------------------------

            int num = 0; //Create a variable of type int and name it num
                        //initialize the variable with a value of 0          
            do // Create a do-while loop and use the template below:
            {
                
                num++; // Increment num by 1
                numbers.Add(num); // Then add num to the collection - numbers
                                 // Hint: reference num inside of the Add method's parentheses
            } while (num < 100);// <---- While your variable is less than 100


            while (num < 200)  // Create a while loop, While num is less than 200
            {
                num++; // Increment num by 1
                numbers.Add(num); // Then add num to the collection numbers
                                 //HINT: copy how this was done in the do while loop
            }

            Console.WriteLine("Increase:"); // This is to show the user that the numbers will start increasing on the console

            foreach (int i in numbers) // Create a foreach loop using the collection - numbers
            {                          //In the scope of the foreach loop, print each number in numbers
                Console.WriteLine(i); 
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {                   // in your initializer set the value of i to 199
                                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                                // AND as long as i is greater than or equal to 0, Decrement i by 1
                Console.WriteLine(i); // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise
        }
    }
}
