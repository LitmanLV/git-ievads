using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)

        {
            for (int i = 1; i <= 21; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    PrintValue(i, "FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    PrintValue(i, "Buzz");
                }

                else if (i % 3 == 0)
                {
                    PrintValue(i, "Fizz");
                }
                else
                {
                    PrintValue(i);
                }

            }

        }
        static void PrintValue(int i, string text)
        {
            Console.WriteLine($"{i} {text}");
        }
    }
}