using System;
namespace Arrays_Strings
{
	public class RotateArray
	{
		public static int[] rotate(int[] arr, int k)
		{
			int len = arr.Length;
			int[] res = new int[len];
			int sum = k / len * arr.Sum();
			k = k % len;
			for (int j = 0; j < len; j++)
			{
				res[j] = sum;
				for (int i = 1; i <= k; i++)
				{
					res[j] += arr[(j - i + len) % len];
				}
			}
			return res;
		}
	}
}

