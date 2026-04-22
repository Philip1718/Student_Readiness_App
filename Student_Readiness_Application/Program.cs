using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Readiness_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("################################# Welcome Back to CTU Student Portal #################################");
            Console.WriteLine();

            Console.Write("Please enter in your student number: ");
            string studentnumber = Console.ReadLine();

            Console.Write("Pleaes enter in your password: ");
            string password = Console.ReadLine();


            if(studentnumber == "20231860" && password == "Philipus@13169")
            {
                Console.WriteLine("Login Successfull");
            }
            else
            {
                Console.WriteLine("Invalid Details, Please try again.");
                Console.WriteLine("Programming exiting....");
                return;
            }


            // This is to get the students marks.

            Console.WriteLine("Please enter in you marks.");

            Console.Write("Maths: ");
            int math = getMarks();

            Console.Write("C#: ");
            int csharp = getMarks();

            Console.Write("Systems Development: ");
            int development = getMarks();

            Console.Write("Database Design: ");
            int database = getMarks();

            Console.Write("System Architecture: ");
            int arch = getMarks();

            Results(math, csharp, development, database, arch);


            int avg = Average(math, csharp, development, database, arch);

            string status = getStatus(avg, 85);

            
            if (status == "Fail")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine($"Final Status: {status}");
            Console.ResetColor();


            Console.ReadLine();


        }

        // This is the functions

        static int getMarks()
        {
            int mark;
            while(!int.TryParse(Console.ReadLine(), out mark) || mark <0 || mark > 100)
            {
                Console.WriteLine("Enter in your Mark (0 - 100): ");

            }
            return mark;

        }

        // This is to display the results

        public static void Results(int math, int csharp, int development, int database, int arch)
        {
            Console.WriteLine("\n==== Results ====");

            PrintResults("Math ", math);
            PrintResults("C# ", csharp);
            PrintResults("Systems Development ", development);
            PrintResults("Database Design ", database);
            PrintResults("System Architecture ", arch);
        }


        static void PrintResults(string subject, int mark)
        {
            if (mark >= 70)
                Console.WriteLine($"{subject}: Passed");
            else
                Console.WriteLine($"{subject}: Not Achieved");
        }

        // Average Methods

        public static int Average(int math, int csharp, int development, int database, int arch)
        {
            int avg = (math + csharp + development + database + arch) / 5;

            Console.WriteLine($"\nAverage: {avg}");

            if(avg >= 75)
            {
                Console.WriteLine("Congratulation! You passed the year.");
            }
            else
            {
                Console.WriteLine("Unfortunatly, you did not pass. ");
            }

            return avg;
        }


        public static string getStatus(int avg)
        {
            return avg >= 75 ? "Pass" : "Fail";

        }

        public static string getStatus(int avg, int distinctionMark)
        {
            if (avg >= distinctionMark)
                return "Distinction";
            else if (avg >= 75)
                return "Pass";
            else
                return "Fail";
        }



    }
}
