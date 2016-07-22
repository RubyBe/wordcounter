
namespace WordCounter
{
  // a class that accepts a word and a string of words, counts the number of occurrences of the initial word within the string of words, and returns the count.
  public class RepeatCounter
  {
    // -------------------------------------------------------------------------
    // properties
    private string _word;

    // -------------------------------------------------------------------------
    // constructors, getters, and setters

    // a constructor which accepts a single string parameter
    public RepeatCounter(string word)
    {
      _word = word;
    }

    // a getter which returns the value of the _word property
    public string GetWord()
    {
      return _word;
    }

    // -------------------------------------------------------------------------
    // other methods
  }
}
