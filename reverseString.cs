using System;

// Write a method that takes in a sentence and returns the sentence with all of the words in reverse order.
// Ex: "This is a sentence." -> "sentence. is a This"

class Program
{
  static void Main()
  {
    Console.WriteLine(reverseString("This is a sentence."));
  }
    static string reverseString(String input)
    {
      string[] splitSentence = input.Split(' ');
      string result = "";
      for(int i = splitSentence.Length-1; i >= 0; i--)
      {
        result += (splitSentence[i] + " ");
      }
      return result;
    }
}
