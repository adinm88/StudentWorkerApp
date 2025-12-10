/***************************************************************
* Name         : FinalProject_Mujakovic
* Author       : Adin Mujakovic
* Created      : 12/04/2025
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : macOS Tahoe 26.0
* IDE          : Visual Studio 2022
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : Asks a user for input for all the parts for an object and prints out a student object or a 
*                studentworker object with many different variables
*                      Inputs :  first name, last name, major, year currently in school, if student worker
*                      then also a wage and a hours worked
*                      Output: returns all of those in 2 parts: a To String that includes the weekly salary
*                      and a Name Plate that excludes it.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace FinalProject_Mujakovic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choice variable for picking which object to create
            int choice;
            // Initialize random
            Random random = new Random();
            // Infinite loop to keep getting input until a number between 1 and 2 inclusive was entered
            while (true)
            {
                // Input validation, no input other than a number that is either 1 or 2
                try
                {
                    Console.Write("Do you want to make a Student or a StudentWorker? (Enter 1 or 2 for the choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine("Student was selected");
                        break;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("StudentWorker was selected");
                        break;
                    }
                    // If number was outside of the range between 1 and 2 inclusive
                    else
                    {
                        Console.WriteLine("Invalid choice, please try again");
                        Console.WriteLine();
                    }
                }
                // Catch the format exception from inputting a letter
                catch (FormatException e)
                {
                    Console.WriteLine("Enter a number.");
                    Console.WriteLine();
                }

            }
            // Second infinite loop to keep grabbing input until the Student or StudentWorker
            // name plate and ToString was printed.
            while (true)
            {
                try
                {
                    Console.Write("Enter a first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter a last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Graduation year?: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What is the major?: ");
                    string major = Console.ReadLine();
                    Console.WriteLine("ID will be randomly generated.");
                    int id = random.Next(1, 65536);
                    // Skip the wage questions if the user chooses to make a Student object
                    if (choice == 1)
                    {
                        Console.WriteLine();
                        Student theStudent = new Student(firstName, lastName, year, major, id);
                        Console.WriteLine("Student was created");
                        Console.WriteLine();
                        Console.WriteLine("To String:");
                        Console.WriteLine(theStudent.ToString());
                        Console.WriteLine();
                        Console.WriteLine("Name Plate:");
                        Console.WriteLine(theStudent.MakeNamePlate());
                        break;
                    }
                    // Continue to ask questions about the wage and hours worked for the StudentWorker object
                    else if (choice == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Since you chose StudentWorker, we have more questions to ask.");
                        Console.Write("Enter the hourly rate this student earns. This must be between" +
                            " $7.25 and $14.75 to get a valid weekly rate that is not 0: ");
                        decimal rate = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter the number of hours this Student works in a day. This must be" +
                            " between 1 and 15 to get a valid weekly rate that is not 0.: ");
                        int hours = Convert.ToInt32(Console.ReadLine());
                        StudentWorker theStudentWorker = new StudentWorker(firstName, lastName, year, major, id, rate, hours);
                        Console.WriteLine();
                        Console.WriteLine("StudentWorker was created.");
                        // If the wage ended up being 0 (invalid)
                        if (theStudentWorker.WeeklySalary == 0m)
                        {
                            Console.WriteLine("You must have entered in a invalid hours worked or invalid hourly rate." +
                                " Please try entering the values again.");
                        }
                        // Prints out the name plate and to string otherwise.
                        else
                        {
                            Console.WriteLine();
                            // Prints both name plate and the ToString
                            Console.WriteLine("Name Plate:");
                            Console.WriteLine(theStudentWorker.MakeNamePlate());
                            Console.WriteLine();
                            Console.WriteLine("To String:");
                            Console.WriteLine(theStudentWorker.ToString());
                            break;

                        }

                    }
                }
                // Catch input that was entered incorrectly or in the wrong format
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input was detected, please try" +
                        " again entering the values!");
                }


            }
        }
    }
}

