using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LetterGradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numeric grade (0-100): ");
            string input = Console.ReadLine();

            //Try to parse the input to an integer
            if (int.TryParse(input, out int grade))
            {
                //Check if the grade is within the valid range
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a grade between 0 and 100.");
                }
                else
                {
                    //Determine the letter grade
                    string letterGrade;
                    if (grade >= 90)
                    {
                        letterGrade = "A";
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = "B";
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = "C";
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = "D";
                    }
                    else
                    {
                        letterGrade = "F";
                    }
                    //Output the letter grade
                    Console.WriteLine($"The letter grade is: {letterGrade}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric grade.");
            }
        }
       
    }   
}
