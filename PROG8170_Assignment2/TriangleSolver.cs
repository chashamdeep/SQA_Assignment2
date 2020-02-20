using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int dimensionOne, int dimensionTwo, int dimensionThree)
        {
            string output = "";
            if (dimensionOne == dimensionTwo && dimensionTwo == dimensionThree)
            {
                output = "The triangle is Equilateral\n";
            }
            else if (dimensionOne == dimensionTwo || dimensionOne == dimensionThree || dimensionTwo == dimensionThree)
            {
                output = "The triangle is Isosceles\n";
            }
            else
            {
                output = "The triangle is Scalene\n";
            }
            return output;
        }
    }
}
