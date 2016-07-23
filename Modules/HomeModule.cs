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
      string upperWord = findWord.ToUpper();
      int countWords = formRepeatCounter.CountRepeats(upperWord, cleanString);
      Console.WriteLine(countWords);
      return View["result.cshtml", formRepeatCounter];
    };
  }
}
