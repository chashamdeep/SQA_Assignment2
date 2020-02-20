using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment2
{
    class Program
    {
        static int choice;
        static string input, validDimensions, output;
        static int dimensionOne, dimensionTwo, dimensionThree;
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("\n 1.Enter triangle Dimensions");
                    Console.WriteLine("\n 2.Exit");
                    choice = CheckValue();
                    MenuAction(choice);
                } while (choice != 2);

            }
            catch(Exception e)
            {
                Console.WriteLine("\n Invalid Choice");
            }
        }
        public static void MenuAction(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter triangle Dimension 1: ");
                    dimensionOne = CheckValue();
                    Console.Write("\nEnter triangle Dimension 2: ");
                    dimensionTwo = CheckValue();
                    Console.Write("\nEnter triangle Dimension 3: ");
                    dimensionThree = CheckValue();
                    //check for valid dimensions
                    bool valid = ValidateDimensions(dimensionOne, dimensionTwo, dimensionThree);
                    if (valid)
                    {
                        validDimensions = "These dimensions could form a triangle\n";
                        //check triangle type 
                        output = TriangleSolver.Analyze(dimensionOne, dimensionTwo, dimensionThree);
                        Console.Write("\nResult : {0}", validDimensions);
                        Console.Write("\nResult : {0}", output);
                    }
                    if(!valid)
                    {
                        validDimensions = "These dimensions could not form a triangle\n";
                        Console.Write("\nResult : {0}", validDimensions);
                    }
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nInput can be either 1 or 2");
                    break;
            }
        }

        //check user input value;
        public static int CheckValue()
        {
            int value;
            do
            {
                input = Console.ReadLine();
                //print if menu options are not valid
                if (!int.TryParse(input, out value) || value < 0)
                {
                    Console.Write("Enter positive integer only\n");
                }
            } while (!int.TryParse(input, out value) || value < 0);
            return value;
        }
        //check dimensions for triangle
        public static bool ValidateDimensions(int dimensionOne, int dimensionTwo, int dimensionThree)
        {
            if(dimensionOne == 0 || dimensionTwo == 0 || dimensionThree == 0)
            {
                return false;
            }
            else if (dimensionOne + dimensionTwo >= dimensionThree || dimensionOne + dimensionThree >= dimensionTwo || dimensionTwo + dimensionThree >= dimensionOne || (dimensionOne == dimensionTwo && dimensionOne == dimensionThree))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
