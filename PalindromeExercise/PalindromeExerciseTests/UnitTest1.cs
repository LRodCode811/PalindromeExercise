using System;
using Xunit;
using PalindromeExerciseTests;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var testThis = new WordSmith();

            //act
            bool actual = testThis.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
