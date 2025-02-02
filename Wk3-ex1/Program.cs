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

                if (grade > 0 || grade < 100)
                { 
                }

                grade = grade / 10;
                Console.WriteLine( "Your letter grade is:  " );
                switch (grade / 10)
                {
                    case 10:
                    case 9:
                        grade = 'A';
                        break;
                    case 8:
                        grade = 'B';
                        break;
                    case 7:
                        grade = 'C';
                        break;
                    case 6:
                        grade = 'D';
                        break;
                    case 5: 
                        grade = 'F';
                        break;
                }

                // Output the letter grade
                Console.WriteLine($"Your letter grade is:  " + grade);
            }
        }

    }
}
    
    

