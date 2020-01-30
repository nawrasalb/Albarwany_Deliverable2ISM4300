// Author:Nawras Albarwany
//Date 1/30/2020
// ISM4300 Conditional statment Deliverable 1

using System;

namespace Albarwany_Deliverable2ISM4300
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays message for user to enter desired grade
            Console.WriteLine("Please enter your desired grade...");

            // try catch to validate user input
            try
            {
                // gather user input
                string input = Console.ReadLine();

                //this variable will store the value the user input. 
                decimal x = decimal.Parse(input);

                //This if/else if statement is used to test the users input and display a letter grade. 
                if ((x >= 98) && (x <=100)) 
                {
                    Console.WriteLine("Course Grade: A+");
                }
                else if ((x >= 92) && (x <= 97))
                {
                    Console.WriteLine("Course Grade: A");
                }
                else if ((x >= 90) && (x <=91))
                {
                    Console.WriteLine("Course Grade: A-");
                }
                else if ((x >= 88) && (x<=89))
                {
                    Console.WriteLine("Course Grade: B+");
                }
                else if ((x >= 82) && (x<=87))
                {
                    Console.WriteLine("Course Grade: B");
                }
                else if ((x >= 80) && (x <=81))
                {
                    Console.WriteLine("Course Grade: B-");
                }
                else if ((x >= 78) && (x <=79))
                {
                    Console.WriteLine("Course Grade: C+");
                }
                else if ((x >= 72) && (x<=77))
                {
                    Console.WriteLine("Course Grade: C");
                }
                else if ((x >= 70) && (x<=71))
                {
                    Console.WriteLine("Course Grade: C-");
                }
                else if ((x >= 68) && (x<=69))
                {
                    Console.WriteLine("Course Grade: D+");
                }
                else if ((x >= 62) && (x<=67))
                {
                    Console.WriteLine("Course Grade: D");
                }
                else if ((x >= 60) && (x<=61))
                {
                    Console.WriteLine("Course Grade: D-");
                }
                else if (x < 60) 
                {
                    Console.WriteLine("Course Grade: F. You Fail!");
                }
                else
                {
                    Console.WriteLine("enter valid number");
                }
            }// end of try 
            catch
            {
                // if user does not enter a decimal value a message displays asking the user to enter an integer
                Console.WriteLine("Please use an integer data type ");
                Console.ReadKey(true);
            } // end of catch 
        }
    }
}
