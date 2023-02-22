using System;
namespace Arrays_Strings
{
	public class FIndPrime
	{
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (i == 2 || i == 3)
                {
                    list.Add(i);
                    continue;
                }
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    if (j == i / 2) { list.Add(i); }
                }
            }
            return list.ToArray();
        }
    }
}

