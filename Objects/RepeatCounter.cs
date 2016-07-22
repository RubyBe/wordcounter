
namespace WordCounter
{
  // a class that accepts a word and a string of words, counts the number of occurrences of the initial word within the string of words, and returns the count.
  public class RepeatCounter
  {
    // -------------------------------------------------------------------------
    // properties
    private string _word;
    private string _stringOfWords;

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

    // -------------------------------------------------------------------------
    // other methods
  }
}
