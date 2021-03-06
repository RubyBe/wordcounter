using System;
using System.Collections.Generic;
using System.IO;
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
    // a setter which sets the value of the _word property
    public void SetWord(string word)
    {
      _word = word;
    }
    // a getter which returns the value of the _stringOfWords property
    public string GetStringOfWords()
    {
      return _stringOfWords;
    }
    // a setter which sets the value of the _stringOfWords property
    public void SetStringOfWords(string stringofwords)
    {
      _stringOfWords = stringofwords;
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
      string capitalWord = singleword.ToUpper();
      string capitalString = stringofwords.ToUpper();
      _listOfWords = capitalString.Split(' ');
      foreach(var word in _listOfWords)
      {
        if (word == capitalWord)
        {
          _countResult += 1;
        }
      }
      return _countResult;
    }

    // a method which strips punctuation from a string
    public string RemovePunctuation(string stringofwords)
    {
      // use the mutable type StringBuilder to not duplicate strings
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

    // a method which reads a file containing the text of War and Peace and returns the full text
    public string ReadAFile()
    {
      string bookLine = "";
      try
      {
        using (StreamReader sr = new StreamReader("Content/warandpeace.txt"))
        {
          bookLine = sr.ReadToEnd();
        }
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      }
      return bookLine;
    }
  }
}
