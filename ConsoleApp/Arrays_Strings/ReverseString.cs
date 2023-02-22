using System;
namespace Arrays_Strings
{
	public class ReverseString
	{
		public static String Reverse1(string s)
		{
			char[] charArray = s.ToCharArray();
			Array.Reverse(charArray);
			string res = new String(charArray);
			Console.WriteLine(res);
			return res;
		}
        public static void Reverse2(string s)
        {
            int i = s.Length - 1;
            int start = i;
            String result = "";

            while (i >= 0)
            {
                result += s[i];
                i--;
            }
            Console.WriteLine(result);

        }
    }
}

