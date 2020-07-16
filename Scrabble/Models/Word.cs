using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word 
  {
    public int WordScore(string word)
    {
      word = word.ToLower();
      int score = 0;
      for (int i = 0; i < word.Length; i++) {
        if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'u' || word[i] == 'l' || word[i] == 'n' || word[i] == 'r' || word[i] == 's'  || word[i] == 't' || word[i] == 'd' || word[i] == 'g') score++;
        else
        {
          score = 0;
          break;
        }
        }         
        return score;
    }
  }
}
