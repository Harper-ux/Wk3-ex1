using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Wk3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            {

                
                // Ask the user to input their overall score
                Console.Write("What is the numeric score (0-100)? ");
                double grade = Convert.ToDouble(Console.ReadLine());
                // Use switch statement to determine the letter grade

                if (grade > 0 || grade < 100) // Check if the grade is within the range of 0-100
                { 
                }

                grade = grade / 10; // Divide the grade by 10 to get the first digit of the grade
                Console.WriteLine( "Your letter grade is:  " );
                switch (grade / 10) // Use the first digit of the grade to determine the letter grade
                {
                    case 10:        // If the grade is 100
                    case 9:        // If the grade is between 90-99
                        grade = 'A';    // Assign the letter grade A
                        break;
                    case 8:       // If the grade is between 80-89
                        grade = 'B';    // Assign the letter grade B
                        break;
                    case 7:      // If the grade is between 70-79
                        grade = 'C';    // Assign the letter grade C
                        break;
                    case 6:     // If the grade is between 60-69        
                        grade = 'D';      // Assign the letter grade D
                        break;
                    case 5:      // If the grade is between 50-59
                        grade = 'F';   // Assign the letter grade F
                        break;
                }

                // Output the letter grade 
                Console.WriteLine($"Your letter grade is:  " + grade);
            }
        }

    }
}
    
    

