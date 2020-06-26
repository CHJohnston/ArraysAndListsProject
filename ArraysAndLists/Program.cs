using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("This is a Single Dimensional Array with the Numbers 1-10");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine($"myArray at Index {i} has the value of {myArray[i]}");
            }
            Console.WriteLine();

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evensList = new List<int>();
            var oddsList = new List<int>();

            //Create a List of valid integers from user input 
            Console.WriteLine("Let's Create a List of Odd and another List of Even Intgers");
            int userInputListLimit = 15;
            var userInputList = new List<int>();
            int userValidIntger = 0;
            Console.WriteLine("Enter 15 Integers");
            for (int i = 1; i <= userInputListLimit; i++) 
            {
                Console.Write($"Enter Integer #{i}: ");
                userValidIntger = NumberConverter(Console.ReadLine());
                userInputList.Add(userValidIntger);               
            }

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var num in userInputList) 
            {
                if (num % 2 == 0) 
                {
                    evensList.Add(num);
                }
                else
                {
                    oddsList.Add(num);
                }               
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            Console.WriteLine();
            Console.WriteLine($"Here is a List of the EVEN Intgers you Entered:");
            foreach (var num in evensList)
            {                
                Console.WriteLine($"Even Integer = {num} ");
            }
            
            Console.WriteLine();
            Console.WriteLine($"Here is a List of the ODD Intgers you Entered:");
            foreach (var num in oddsList)
            {
                Console.WriteLine($"Odd Integer = {num} ");
            }
        }
        public static int NumberConverter(string str)
        //Check for Integer and keep asking user until a valid Integer is entered
        {
            int result;
            // The user will be asked to renter a value until a vaild integer is input
            while (int.TryParse(str, out result) == false)
            {
                Console.WriteLine($"{str} is not a valid Integer");
                Console.Write("Try Again ");
                str = Console.ReadLine();
            }
            return result;
        }
    }
}
