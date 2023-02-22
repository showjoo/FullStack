using System;
namespace Exercise03
{
	public class Greet
	{
		public void Greets(DateTime time)
		{
			if (time.Hour<=6)
			{
				Console.WriteLine("Good Night");
			}
            else if (time.Hour <=12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time.Hour <= 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (time.Hour <= 24)
            {
                Console.WriteLine("Good Evening");
            }
        }
	}
}

