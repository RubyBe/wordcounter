using System;
using Xunit;


// Unit tests for the RepeatCounter class
namespace WordCounter
{
  public class RepeatCounterTest
  {
    // a test of the ability for the program to accept a single-word string as an input and return it for display
    [Fact]
    public void RepeatCounter_CreatesARepeatCounterObjectWithAWordProperty_ReturnsValueOfWordProperty()
    {
      // Arrange
      string testString = "antelope";

      // Act
      RepeatCounter testRepeatCounter = new RepeatCounter(testString);
      string resultString = testRepeatCounter.GetWord();

      // Assert
      Console.WriteLine("Spec 1 expected: " + testString + " and actual: " + resultString);
      Assert.Equal(testString, resultString);
    }
  }
}
