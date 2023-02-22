using System;
namespace Exercise03
{
	public class FizzBuzz
	{
        public void simulate(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                if (i % 15 == 0)
                { Console.WriteLine("fizzbuzz"); }
                else if (i % 3 == 0)
                { Console.WriteLine("fizz"); }
                else if (i % 5 == 0)
                { Console.WriteLine("buzz"); }
                else
                { Console.WriteLine(i); }
            }
        }
	}
}

