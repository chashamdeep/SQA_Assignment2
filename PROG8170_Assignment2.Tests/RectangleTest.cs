using System;
using NUnit.Framework;

namespace PROG8170_Assignment2.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        //Test Case: 1
        //Test Description: Analyze the triangle type
        //Input Data: 20,20,20
        //Expected Data: The triangle is Equilateral\n
        [Test]
        public void Test_Analyze_Input_20_20_20_Expected_Ouptut_Equilateral_Triangle()
        {
            string result = TriangleSolver.Analyze(20, 20, 20);
            Assert.AreEqual("The triangle is Equilateral\n", result);
        }

        //Test Case: 2
        //Test Description: Analyze the triangle type
        //Input Data: 5,5,5
        //Expected Data: The triangle is Equilateral\n
        [Test]
        public void Test_Analyze_Input_5_5_5_Expected_Ouptut_Equilateral_Triangle()
        {
            string result = TriangleSolver.Analyze(5, 5, 5);
            Assert.AreEqual("The triangle is Equilateral\n", result);
        }

        //Test Case: 3
        //Test Description: Analyze the triangle type
        //Input Data: 20,20,30
        //Expected Data: The triangle is Isosceles\n
        [Test]
        public void Test_Analyze_Input_20_20_30_Expected_Ouptut_Isocsceles_Triangle()
        {
            string result = TriangleSolver.Analyze(20, 20, 30);
            Assert.AreEqual("The triangle is Isosceles\n", result);
        }

        //Test Case: 4
        //Test Description: Analyze the triangle type
        //Input Data: 3,30,30
        //Expected Data: The triangle is Isosceles\n
        [Test]
        public void Test_Analyze_Input_3_30_30_Expected_Ouptut_Isocsceles_Triangle()
        {
            string result = TriangleSolver.Analyze(3, 30, 30);
            Assert.AreEqual("The triangle is Isosceles\n", result);
        }

        //Test Case: 5
        //Test Description: Analyze the triangle type
        //Input Data: 4,8,4
        //Expected Data: The triangle is Isosceles\n
        [Test]
        public void Test_Analyze_Input_4_8_4_Expected_Ouptut_Isocsceles_Triangle()
        {
            string result = TriangleSolver.Analyze(4, 8, 4);
            Assert.AreEqual("The triangle is Isosceles\n", result);
        }

        //Test Case: 6
        //Test Description: Analyze the triangle type
        //Input Data: 17,15,19
        //Expected Data: The triangle is Scalene\n
        [Test]
        public void Test_Analyze_Input_17_15_19_Expected_Ouptut_Scalene_Triangle()
        {
            string result = TriangleSolver.Analyze(17, 15, 19);
            Assert.AreEqual("The triangle is Scalene\n", result);
        }

        //Test Case: 7
        //Test Description: Analyze the triangle type
        //Input Data: 100,95,86
        //Expected Data: The triangle is Scalene\n
        [Test]
        public void Test_Analyze_Input_100_95_86_Expected_Ouptut_Scalene_Triangle()
        {
            string result = TriangleSolver.Analyze(100, 95, 86);
            Assert.AreEqual("The triangle is Scalene\n", result);
        }

        //Test Case: 8
        //Test Description: Analyze the triangle type
        //Input Data: 8,10,12
        //Expected Data: The triangle is Scalene\n
        [Test]
        public void Test_Analyze_Input_8_10_12_Expected_Ouptut_Scalene_Triangle()
        {
            string result = TriangleSolver.Analyze(8, 10, 12);
            Assert.AreEqual("The triangle is Scalene\n", result);
        }
    }
}
