using System;
using System.Collections.Generic;
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
      string testWord = "antelope";
      // Act
      RepeatCounter testRepeatCounter = new RepeatCounter(testWord);
      string resultString = testRepeatCounter.GetWord();
      // Assert
      Console.WriteLine("Spec 1 expected: " + testWord + " and actual: " + resultString);
      Assert.Equal(testWord, resultString);
    }

    // a test of the ability of the program to accept a string of words as an input and return it for display
    [Fact]
    public void RepeatCounter_CreatesARepeatCounterObjectWithAStringOfWordsProperty_ReturnsValueOfStringProperty()
    {
      // Arrange
      string testString = "An antelope is like a gazelle in a way but it begins with an A actually.";
      // Act
      RepeatCounter testRepeatCounter = new RepeatCounter(testString);
      string resultString = testRepeatCounter.GetString();
      // Assert
      Assert.Equal(testString, resultString);
    }
  }
}
