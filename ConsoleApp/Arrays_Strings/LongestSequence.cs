using System;
namespace Arrays_Strings
{
	public class LongestSequence
	{
		public static void sequence(int[] arr)
		{
			int len = arr.Length;
			int start = arr[0];
			int maxlen = 1, curlen = 1;
			int res = start;
			
			for (int i = 1; i < len; i++)
			{
				if (arr[i] == start)
				{
					curlen += 1;
					if (curlen > maxlen) {
                        maxlen = curlen;
						res = start;
                    }					
				}
				else
				{
					curlen = 1;
					start = arr[i];
				}
			}
            string sp = "";
            for (int i = 0; i < maxlen; i++)
            { sp = sp + res + " "; }
			Console.WriteLine(sp);
		}
	}
}

