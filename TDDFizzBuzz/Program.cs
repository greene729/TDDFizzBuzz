using System;

namespace TDDFizzBuzz
{
    public static class Program
    {
        private static void Main()
        {
            var fizzBuzz = new FizzBuzz();
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.Play(i));
            }
        }
    }
}