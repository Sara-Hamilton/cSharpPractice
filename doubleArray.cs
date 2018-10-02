using System;

// Given an array of integers, return a new array with each value doubled.
// For example:
// [1, 2, 3] --> [2, 4, 6]

class Program
{
  static void Main()
  {
    int[] sampleData = new int[] {1,2,3};
    // doubleArray(sampleData);
    Console.Write("[" + string.Join(",", doubleArray(sampleData)) + "]");
  }

    static int[] doubleArray(int[] input)
    {
      for(int i=0; i < input.Length; i++)
      {
        input[i] *=2;
      }
      return input;
    }
}
