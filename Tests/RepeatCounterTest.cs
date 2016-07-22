using System;
using System.Collections.Generic;
using Xunit;


// Unit tests for the RepeatCounter class
namespace WordCounter
{
  public class RepeatCounterTest
  {
    // Because we are not saving instances of the RepeatCounter class, IDisposable is not required

    // Spec1: test of the ability for the program to accept a single-word string as an input and return it for display - test removed and combined with Spec2 test

    // Spec2 & Spec3: test of the ability of the program to accept a string of words as an input and return it for display - combining tests for spec 1 and 2 to accomodate a single constructor which accepts two strings. Combining it ended up being a test for Spec3 as well.
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
      Console.WriteLine("Spec 2 expected: " + testString + " Spec2 actual: " + resultString);
      Assert.Equal(testWord, resultWord);
      Assert.Equal(testString, resultString);
    }

    // Spec4: test of the ability of the program to scan the submitted string of words and find occurrences of the submitted single word string
    [Fact]
    public void FindWord_FindsWordInStringOfMultipleWords_DisplaysTrueIfFound()
    {
      // Arrange
      string testWord = "antelope";
      string testString = "An antelope is like a gazelle in a way but it begins with an A actually.";
      RepeatCounter testRepeatCounter = new RepeatCounter(testWord, testString);
      // Act
      string resultString = testRepeatCounter.FindWord(testWord, testString);
      // Assert
      Console.WriteLine("Spec 4 expected: " + testString + " Spec4 actual: " + resultString);
      Assert.Equal(resultString, "True");
    }

    // Spec5: test of ability of program to count the number of times a submitted single word is found in a submitted string of multiple words
    [Fact]
    public void CountRepeats_CountsWordReptitionInStringOfMultipleWords_ReturnsCountOfRepeats()
    {
      // Arrange
      string testWord = "antelope";
      string testString = "An antelope is like a gazelle in a way but it begins with an A actually.";
      int testCount = 1;
      RepeatCounter testRepeatCounter = new RepeatCounter(testWord, testString);
      // Act
      int resultCount = testRepeatCounter.CountRepeats(testWord, testString);
      // Assert
      Console.WriteLine("Spec 5 expected: " + testCount + " Spec5 actual: " + resultCount);
      Assert.Equal(testCount, resultCount);
    }

    // Spec6: test of ability of program to count the number of times a submitted single word is found in a submitted string of multiple words, regardless of case
    [Fact]
    public void FindWord_FindsWordInStringOfMultipleWordsCapitalizedOrNot_ReturnsCountOfRepeatsRegardlessOfCase()
    {
      // Arrange
      string testWord = "a";
      string testString = "An antelope is like a gazelle in a way but it begins with an A actually.";
      int testCount = 3;
      RepeatCounter testRepeatCounter = new RepeatCounter(testWord, testString);
      // Act
      int resultCount = testRepeatCounter.CountRepeats(testWord, testString);
      // Assert
      Console.WriteLine("Spec 6 expected: " + testCount + " Spec6 actual: " + resultCount);
      Assert.Equal(testCount, resultCount);
    }

  }
}
