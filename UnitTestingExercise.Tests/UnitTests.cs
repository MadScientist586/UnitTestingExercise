using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(-8, 5, 3, 0)]
        [InlineData(-232, 76, -23, -179)]
        [InlineData(103, 45, 27, 175)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var add = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = add.Add(num1, num2, num3);
          

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, -1)] //Add test data <-------
        [InlineData(-8, 5, -13)]
        [InlineData(-232, 76, -308)]
        [InlineData(103, 45, 58)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var sub = new Calculator();
            var actual = sub.Subtract(minuend, subtrhend);  
            Assert.Equal(expected, actual);
            //Act

            //Assert

        }

        [Theory]
        [InlineData(2, 3, 6)] //Add test data <-------
        [InlineData(8, 5, 40)]
        [InlineData(2, 76, 152)]
        [InlineData(3, 45, 135)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var multip = new Calculator();  
            //Act
            var actual = multip.Multiply(num1, num2);   
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 2, 2)] //Add test data <-------
        [InlineData(100, 5, 20)]
        [InlineData(76, 2, 38)]
        [InlineData(36, 6, 6)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var div = new Calculator(); 
            //Act
            var actual = div.Divide(num1, num2);    

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
