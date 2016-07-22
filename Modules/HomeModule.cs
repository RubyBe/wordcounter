using Nancy;
using WordCounter;

public class HomeModule : NancyModule
{
  public HomeModule()
  {
    Get["/"] = _ =>
    {
      RepeatCounter formRepeatCounter = new RepeatCounter(Request.Form["input-word"], Request.Form["input-list"]);
      string firstString = formRepeatCounter.GetStringOfWords();
      string cleanString = formRepeatCounter.RemovePunctuation(firstString);
      string findWord = formRepeatCounter.GetWord();
      int countWords = formRepeatCounter.CountRepeats(findWord, cleanString);

      return View["index.html"];
    };

    Post["/result"] = _ =>
    {
      return View["result.cshtml"];
    };
  }
}
