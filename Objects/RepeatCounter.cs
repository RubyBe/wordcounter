using System.Collections.Generic;
using System.Text;

namespace WordCounter
{
  // a class that accepts a word and a string of words, counts the number of occurrences of the initial word within the string of words, and returns the count.
  public class RepeatCounter
  {
    // -------------------------------------------------------------------------
    // properties
    private string _word;
    private string _stringOfWords;
    private string[] _listOfWords;
    private int _countResult;

    // -------------------------------------------------------------------------
    // constructors, getters, and setters

    // a constructor which requires 2 parameters: a string which will hold a single word, and a string which will hold a string of words
    public RepeatCounter(string word, string stringofwords)
    {
      _word = word;
      _stringOfWords = stringofwords;
    }
    // a getter which returns the value of the _word property
    public string GetWord()
    {
      return _word;
    }
    // a getter which returns the value of the _stringOfWords property
    public string GetStringOfWords()
    {
      return _stringOfWords;
    }
    // a getter which returns the count of _word in _stringOfWords
    public int GetCount()
    {
      return _countResult;
    }

    // -------------------------------------------------------------------------
    // other methods

    // a method which searches the submitted list of multiple words and finds whether or not the submitted single word exists in the list of words
    public string FindWord(string singleword, string stringofwords)
    {
      string findResult = "False";
      _listOfWords = stringofwords.Split(' ');
      foreach(var word in _listOfWords)
      {
        if (word == singleword)
        {
          findResult = "True";
        }
      }
      return findResult;
    }

    // a method which searches the submitted list of multiple words and finds whether or not the submitted single word exists in the list of words, and counts the occurrences of the word
    public int CountRepeats(string singleword, string stringofwords)
    {
      string capitalString = stringofwords.ToUpper();
      _listOfWords = capitalString.Split(' ');
      foreach(var word in _listOfWords)
      {
        if (word == singleword)
        {
          _countResult += 1;
        }
      }
      return _countResult;
    }

    // a method which strips punctuation from a string
    public string RemovePunctuation(string stringofwords)
    {
      StringBuilder stringOfWords = new StringBuilder(stringofwords);
      stringOfWords.Replace(".", "");
      stringOfWords.Replace("!", "");
      stringOfWords.Replace("?", "");
      stringOfWords.Replace("-", "");
      stringOfWords.Replace("\"", "");
      stringOfWords.Replace("\'", "");
      stringOfWords.Replace("\\", "");

      string newStringOfWords = stringOfWords.ToString();
      return newStringOfWords;
    }

  }
}
