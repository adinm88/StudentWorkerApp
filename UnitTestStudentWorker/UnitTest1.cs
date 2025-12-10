using System.Net;
using FinalProject_Mujakovic;
/***************************************************************
* Name         : UnitTestStudentWorker
* Author       : Adin Mujakovic
* Created      : 12/04/2025
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : macOS Tahoe 26.0
* IDE          : Visual Studio 2022
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : Runs unit tests on the WeeklySalary formula based on the correct StudentWorker.cs file
*                      Input : None
*                      Output: Passing or Failing unit tests based on the correct StudentWorker.cs file
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace UnitTestStudentWorker
{
    public class UnitTest1
    {
        // Test if the hours are lower than the range and the wage is 0 because of that
        [Fact]
        public void TestInvalidHoursLow()
        {
            // ARRANGE
            StudentWorker a = new StudentWorker("John", "Doe", 2026, "Computer Science", 1, 12.0m, -1);
            decimal actual, expected = 0m;
            // ACT
            actual = a.CalculateWeeklyPay();

            // ASSERT 
            Assert.Equal(expected, actual);
            Console.WriteLine(Convert.ToString(actual));
        }
        // Test if the hours are higher than the range and the wage is 0 because of that
        [Fact]
        public void TestInvalidHoursHigh()
        {
            // ARRANGE
            StudentWorker a = new StudentWorker("John", "Doe", 2026, "Computer Science", 1, 12.0m, 67);
            decimal actual, expected = 0m;
            // ACT
            actual = a.CalculateWeeklyPay();

            // ASSERT 
            Assert.Equal(expected, actual);
            Console.WriteLine(Convert.ToString(actual));
        }
        // Test if the wage is lower than the range and the wage is 0 because of that
        [Fact]
        public void TestInvalidWageLow()
        {
            // ARRANGE
            StudentWorker a = new StudentWorker("John", "Doe", 2026, "Computer Science", 1, 5.55m, 8);
            decimal actual, expected = 0m;
            // ACT
            actual = a.CalculateWeeklyPay();

            // ASSERT 
            Assert.Equal(expected, actual);
            Console.WriteLine(Convert.ToString(actual));
        }
        // Test if the wage is higher than the range and the wage is 0 because of that
        [Fact]
        public void TestInvalidWageHigh()
        {
            // ARRANGE
            StudentWorker a = new StudentWorker("John", "Doe", 2026, "Computer Science", 1, 25.67m, 8);
            decimal actual, expected = 0m;
            // ACT
            actual = a.CalculateWeeklyPay();

            // ASSERT 
            Assert.Equal(expected, actual);
            Console.WriteLine(Convert.ToString(actual));
        }
        // Test a valid wage and valid hours worked and test printing out the correct weekly salary
        [Fact]
        public void ValidityTest()
        {
            // ARRANGE
            StudentWorker a = new StudentWorker("John", "Doe", 2026, "Computer Science", 1, 10.50m, 8);
            decimal actual, expected = 588m;
            // ACT
            actual = a.CalculateWeeklyPay();

            // ASSERT 
            Assert.Equal(expected, actual);
            Console.WriteLine(Convert.ToString(actual));
        }
    }
}


