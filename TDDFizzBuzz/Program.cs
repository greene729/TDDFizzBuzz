using System;

namespace TDDFizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.Play(i));
            }
        }
    }
}