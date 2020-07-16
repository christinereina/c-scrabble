using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {

    [TestMethod]
    public void Word_CreatesNewWord_Word()
    {
      Word newWord = new Word();
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void CalculateScore_WordScore_Int()
    {
      Word newWord = new Word();
      int score = newWord.WordScore("got");
      Assert.AreEqual(4, score);

    }



  }
}


