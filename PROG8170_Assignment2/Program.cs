using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment2
{
    class Program
    {
        static int userChoice;
        static string inputString;
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("\n*******************\n");
                    Console.WriteLine("\n 1.Enter triangle Dimensions");
                    Console.WriteLine("\n 2.Exit");
                    Console.Write("\n Enter your choice; ");
                    userChoice = GetValue();
                } while (userChoice != 2);

            }
            catch (FormatException e1)
            {
                Console.WriteLine("\n Format Exception: Given input was Invalid");
            }
            catch (Exception e2)
            {
                Console.WriteLine("\n Exception Arise: Segmentation falut/Runtime problem");
            }

        }

        // get and check user input value;
        public static int GetValue()
        {
            int value;
            do
            {
                Console.Write("Please a +ve integer number only : ");
                inputString = Console.ReadLine();
            } while (!int.TryParse(inputString, out value) || value < 0);
            return value;
        }
    }
}
