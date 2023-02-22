using System;
namespace Exercise03
{
	public class GuessNumber
	{
        public void guess()
        {
            Random rnd = new Random();
            int guessedNumber = int.Parse(Console.ReadLine());
            int ans = rnd.Next(1, 4);
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Guess Out Of Range - Your guess should fall in range(1,3)");
            }
            else if (guessedNumber > ans)
            {
                Console.WriteLine("Guess is too high");
            }
            else if (guessedNumber < ans)
            {
                Console.WriteLine("Guess is too low");
            }
            else
            {
                Console.WriteLine("Guess correct");
            }
        }
    }
}

