using System;
namespace Exercise03
{
	public class Counting24
	{
		public void count()
		{
			for (int i = 1; i <= 4; i++)
			{
				string str = "";
				int start = 0;
				for (; start <= 24; start += i)
				{
					if (start != 24)
					{ str = str + start + ", "; }
					else
					{ str += start; }
				}
				Console.WriteLine(str);
			}
		}
	}
}

