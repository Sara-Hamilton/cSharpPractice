using System;

// Write a method isNarcissistic(i) which returns whether or not i is a Narcissistic Number. A Narcissistic Number is a number of length n in which the sum of its digits to the power of n is equal to the original number. If this seems confusing, refer to the example below.
// Ex: 153, where n = 3 (number of digits in 153)
// 1cubed + 5cubed + 3cubed = 153

class Program
{
  static void Main()
  {
    Console.WriteLine(isNarcissistic(0));
    Console.WriteLine(isNarcissistic(153));
    Console.WriteLine(isNarcissistic(22));
  }

  static bool isNarcissistic(int input)
  {
    int result = 0;
    string inputString = input.ToString();

    for (int i = 0; i <= inputString.Length - 1; i++)
    {
      int number = (int)char.GetNumericValue(inputString[i]);
      int numberToPowerOfInputLength = (int)Math.Pow(number, inputString.Length);
      result += numberToPowerOfInputLength;
    }

    if (result == input)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}
