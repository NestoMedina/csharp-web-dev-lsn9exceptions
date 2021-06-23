using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            try
            {
                if (y == 0)
                {
                    throw new ArgumentOutOfRangeException("Values cannot be 0");
                }
                else
                {
                    Console.WriteLine(x / y);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                y = 1;
                Console.WriteLine(e);
            }

            return x / y;
        }

        //receive string parse final output as int
        //if string ends in .cs they get 1 point, no .cs 0 points
        //if string is empty or null throw exception
        static int CheckFileExtension(string fileName)
        {
            int i = 0;
            try
            {
                if (fileName.Contains(".cs") == true)
                {
                    i++;
                }
                else if (fileName == null || fileName == "")
                {
                    throw new ArgumentNullException("No program was entered");
                }
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine($"This program receives {i} point(s).");
            return i;
            }
        

        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            //(2, 0);

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            CheckFileExtension("program");

        }
    }
}
