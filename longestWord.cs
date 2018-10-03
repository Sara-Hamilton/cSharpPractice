using System;

// Have the function LongestWord(sen) take the sen parameter being passed and return the largest word in the string. If there are two or more words that are the same length, return the first word from the string with that length. Ignore punctuation and assume sen will not be empty.
// Sample Test Cases
//   Input:"fun&!! time"
//   Output:"time"
//
//   Input:"I love dogs"
//   Output:"love"

class Program
{
  static void Main()
  {
    Console.WriteLine(LongestWord("fun&!! time"));
    Console.WriteLine(LongestWord("I love dogs"));
  }

  static string LongestWord(string sen)
  {
    string[] words = sen.Split(' ');
    string longest = "";
    foreach (string word in words)
    {
      string strippedWord = stripPunctuation(word);
      if (strippedWord.Length > longest.Length)
      {
        longest = strippedWord;
      }
    }
    return longest;
  }

  static string stripPunctuation(string input)
  {
    char[] elements = input.ToCharArray();
    string result = "";
    foreach(char element in elements)
    {
      if (!(char.IsPunctuation(element)))
      {
        result += element.ToString();
      }
    }
    return result;
  }

}
