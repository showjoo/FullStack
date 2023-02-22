using System;
namespace Arrays_Strings
{
	public class MostFreq
	{
		public static int GetNum(int[] arr)
		{
            int n = arr.Length;
            Dictionary<int, int> hp = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int key = arr[i];
                if (hp.ContainsKey(key))
                {
                    int freq = hp[key];
                    freq++;
                    hp[key] = freq;
                }
                else
                    hp.Add(key, 1);
            }

            // find max frequency.
            int min_count = 0, res = -1;

            foreach (KeyValuePair<int,
                        int> pair in hp)
            {
                if (min_count < pair.Value)
                {
                    res = pair.Key;
                    min_count = pair.Value;
                }
            }
            return res;
        }
	}
}

