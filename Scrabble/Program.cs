using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble
{
  class Program
  {
    // public static List<Word> newWord = new List<Word> {};
  
    public static void Main()
    {
      Console.WriteLine("Welcome to The Scrabble Score App");
      Console.WriteLine("Please enter a word in the console");
      string input = Console.ReadLine();
      Word newInput = new Word();
      // maps to Class "Word" - line 6
      int score = newInput.WordScore(input);
      // maps to Method "WordScore" - line 8
      Console.WriteLine("Your score is:" + score);
    }

  }
}



