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
                if (x >= 98)
                {
                    Console.WriteLine("Course Grade: A+");
                }
                else if (x >= 92)
                {
                    Console.WriteLine("Course Grade: A");
                }
                else if (x >= 90)
                {
                    Console.WriteLine("Course Grade: A-");
                }
                else if (x >= 88)
                {
                    Console.WriteLine("Course Grade: B+");
                }
                else if (x >= 82)
                {
                    Console.WriteLine("Course Grade: B");
                }
                else if (x >= 80)
                {
                    Console.WriteLine("Course Grade: B-");
                }
                else if (x >= 78)
                {
                    Console.WriteLine("Course Grade: C+");
                }
                else if (x >= 72)
                {
                    Console.WriteLine("Course Grade: C");
                }
                else if (x >= 70)
                {
                    Console.WriteLine("Course Grade: C-");
                }
                else if (x >= 68)
                {
                    Console.WriteLine("Course Grade: D+");
                }
                else if (x >= 62)
                {
                    Console.WriteLine("Course Grade: D");
                }
                else if (x >= 60)
                {
                    Console.WriteLine("Course Grade: D-");
                }
                else if (x < 60)
                {
                    Console.WriteLine("Course Grade: F. You Fail!");
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
