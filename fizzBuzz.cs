using System;

// Write a program that prints a specified range of numbers. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”.

class Program
{
  static void Main()
  {
    fizzBuzzA(25);
    fizzBuzzB(25);
  }

  static void fizzBuzzA(int number)
  {
    for (var i=1; i <= number; i++)
    {
      if ((i % 3 == 0) && (i % 5 == 0))
      {
        Console.WriteLine("FizzBuzz");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("Fizz");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("Buzz");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }

  // Variation - Print out numbers.  If the number is evenly divisible by three, add "Fizz" after the number.  If the number is evenly divisible by 5, add "Buzz" after the number.  If the number is evenly divisible by both 3 and 5, add "Fizz Buzz" after the number.
  static void fizzBuzzB(int number)
  {
    for (var i=1; i <= number; i++)
    {
      string next = i.ToString();
      if(i % 5 == 0)
      {
        next += " Fizz";
      }
      if(i % 3 == 0)
      {
        next += " Buzz";
      }
      Console.WriteLine(next);
      }
    }
  }
