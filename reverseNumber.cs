using System;

// Given a number, write a function to output its reverse digits. (e.g. given 123 the answer is 321)
// Numbers should preserve their sign; i.e. a negative number should still be negative when reversed.
// Examples
// 123 -> 321
// -456 -> -654
// 1000 -> 1

class Program
{
  static void Main()
  {
    Console.WriteLine(reverseNum(123));
    Console.WriteLine(reverseNum(-456));
    Console.WriteLine(reverseNum(1000));
  }

  static int reverseNum(int num)
  {
    string result = "";
    string numString = num.ToString();
    if (num < 0)
    {
      result += "-";
      numString = numString.Substring(1, numString.Length - 1);
    }
    for (var i = numString.Length - 1; i >= 0; i--)
    {
      result += numString[i];
    }
    return Int32.Parse(result);
  }

}
