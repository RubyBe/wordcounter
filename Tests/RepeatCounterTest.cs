using System;
using System.Collections.Generic;
using Xunit;


// Unit tests for the RepeatCounter class
namespace WordCounter
{
  public class RepeatCounterTest
  {
    // Spec1: test of the ability for the program to accept a single-word string as an input and return it for display - test removed and combined with Spec2 test

    // Spec2: test of the ability of the program to accept a string of words as an input and return it for display - combining tests for spec 1 and 2 to accomodate a single constructor which accepts two strings
    [Fact]
    public void RepeatCounter_CreatesARepeatCounterObjectWithTwoStrings_ReturnsValueOfTwoStrings()
    {
      // Arrange
      string testWord = "antelope";
      string testString = "An antelope is like a gazelle in a way but it begins with an A actually.";
      // Act
      RepeatCounter testRepeatCounter = new RepeatCounter(testWord, testString);
      string resultWord = testRepeatCounter.GetWord();
      string resultString = testRepeatCounter.GetStringOfWords();
      // Assert
      Console.WriteLine("Spec 1 expected: " + testWord + " Spec1 actual: " + resultWord);
      Console.WriteLine("Spec 2 expected: " + testString + " Spect2 actual: " + resultString);
      Assert.Equal(testWord, resultWord);
      Assert.Equal(testString, resultString);
    }
  }
}
