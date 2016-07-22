using Nancy;
using System;
using WordCounter;

public class HomeModule : NancyModule
{
  public HomeModule()
  {
    Get["/"] = _ =>
    {
      return View["index.html"];
    };

    Post["/result"] = _ =>
    {
      RepeatCounter formRepeatCounter = new RepeatCounter(Request.Form["input-word"], Request.Form["input-list"]);
      string firstString = formRepeatCounter.GetStringOfWords();
      string cleanString = formRepeatCounter.RemovePunctuation(firstString);
      string findWord = formRepeatCounter.GetWord();
      int countWords = formRepeatCounter.CountRepeats(findWord, cleanString);
      Console.WriteLine(firstString);
      return View["result.cshtml", formRepeatCounter];
    };
  }
}
