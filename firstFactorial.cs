using System;

// have the function FirstFactorial(num) take the num parameter being passed and return the factorial of it (e.g. if num = 4, return (4 * 3 * 2 * 1)). For the test cases, the range will be between 1 and 18 and the input will always be an integer.
//
// Sample Test Cases
// Input:4
// Output:24
//
// Input:8
// Output:40320

class Program
{
  static void Main()
  {
    Console.WriteLine(FirstFactorial(4));
    Console.WriteLine(FirstFactorial(8));
    Console.WriteLine(FirstFactorial(0));
    Console.WriteLine(FirstFactorial(1));
  }

  static int FirstFactorial(int num)
  {
    for(int i = num-1; i > 0; i--)
    {
      num *= i;
    }
    return num;
  }
}
