using Nancy;
using System;
using System.IO;
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
      return View["result.cshtml", formRepeatCounter];
    };

    Post["/warandpeace"] = _ =>
    {
      RepeatCounter wapRepeatCounter = new RepeatCounter(Request.Form["input-word"], Request.Form["input-word"]);
      string readWarAndPeace = wapRepeatCounter.ReadAFile();
      wapRepeatCounter.SetStringOfWords(readWarAndPeace);
      string firstString = wapRepeatCounter.GetStringOfWords();
      string cleanString = wapRepeatCounter.RemovePunctuation(firstString);
      string findWord = wapRepeatCounter.GetWord();
      int countWords = wapRepeatCounter.CountRepeats(findWord, cleanString);
      return View["warandpeace.cshtml", wapRepeatCounter];
    };
  }
}
