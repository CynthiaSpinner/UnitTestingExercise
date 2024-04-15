using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(4, 16, 24, 44)]
        [InlineData(-3, -4, 8, 1)]
        [InlineData(8, -2, 12, 18)]
        //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            Calculator challenger = new Calculator();
            //Arrange
            // create a Calculator object
            int actual = challenger.Add(num1, num2, num3);

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            Assert.Equal(expected, actual);
            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 2, 7)]
        [InlineData(89,3, 86)]
        [InlineData(-98, 8, -106)]
        [InlineData(904, 0, 904)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator challenger = new Calculator();
            //Act
            int actual = challenger.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(37, 67, 2479)]
        [InlineData(68, 0, 0)]
        [InlineData(409, 1, 409)]
        [InlineData(-98, 45, -4410)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challenger = new Calculator();
            //Act
            int actual = challenger.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(10, 2, 5)]
        [InlineData(67, 8, 8)]
        [InlineData(8, 4, 2)] //Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenge = new Calculator();

            //Act
            int actual = challenge.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
