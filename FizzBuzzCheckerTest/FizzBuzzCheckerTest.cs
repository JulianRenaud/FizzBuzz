using FizzBuzz;

namespace FizzBuzzCheckerTest
{
    public class FizzBuzzCheckerTest
    {
        [Theory]
        [InlineData(9, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(11, "This number is not divisible by 3 or 5!")]
        public void Test1(int fizzBuzz, string expected)
        {
            //Arrange
            var fizzBuzzVar = new FizzBuzzChecker();

            //Act
            var actual = fizzBuzzVar.FizzBuzzCheck(fizzBuzz);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}