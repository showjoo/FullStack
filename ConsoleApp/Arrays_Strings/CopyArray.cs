using System;
namespace Arrays_Strings
{
	public class CopyArray
	{
		public int[] copy(int[] arr1)
		{
			int len = arr1.Length;
			int[] arr2 = new int[len];
			for (int i = 0; i < len; i++)
			{
				arr2[i] = arr1[i];
			}
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Console.WriteLine("[{0}]", string.Join(", ", arr2));
            return arr2;
		}
	}
}

