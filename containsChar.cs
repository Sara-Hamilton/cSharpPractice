using System;

// You will be given an array of characters (a) and a value (x).
// Check whether the provided array contains the value.
// Return true if the array contains the value, false if not.

class Program
{
  static void Main()
  {
    char[] sampleCharArray = new char[] {'a', 'b', 'c'};

    Console.WriteLine(containsAlternative(sampleCharArray, 'c'));
    Console.WriteLine(containsAlternative(sampleCharArray, 'x'));
  }

  static bool containsAlternative(char[] inputArray, char x)
  {
    for (int i = 0; i < inputArray.Length; i++)
    {
      if (inputArray[i] == x)
      {
        return true;
      }
    }
      return false;
  }
}
