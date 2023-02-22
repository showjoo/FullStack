using System;
namespace Arrays_Strings
{
	public class ExtractPalindromes
	{
		public static void extract(string str)
		{
			List<string> res = new List<string>();
            Char[] punctuations = { '.', ' ', ',', ':', ';', '=', '(', ')', '&', '[', ']', '!', '?' };
            string[] words = str.Split(punctuations);
			foreach (string word in words)
			{
				if (word == "")
					continue;
				char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reverse_word = new String(charArray);
				if (word == reverse_word)
					res.Add(word);
			}
			res.Sort();
			Console.WriteLine("{0}", string.Join(", ", res));
        }
	}
}

