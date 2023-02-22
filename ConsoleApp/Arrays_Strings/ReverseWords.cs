using System;
using System.Text;

namespace Arrays_Strings
{
	public class ReverseWords
	{
        public static string Reverse(string str)
        {
            StringBuilder answer = new StringBuilder();
            Char[] punctuations = { '.', ' ', ',', ':', ';', '=', '(', ')', '&', '[', ']', '!', '?' };
            string[] words = str.Split(punctuations);
            Console.WriteLine("[{0}]", string.Join(',', words));
            List<char> list = new List<char>(); 
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' && punctuations.Contains(str[i]))
                    list.Add(str[i]);
            }
            int j = 0;
            for (int position = 0; position <= words.Length - 1; position++)
            {
                if (words[words.Length - position - 1] != "")
                {
                    answer.Append(words[words.Length - position - 1]);
                    answer.Append(' ');
                }
                if (words[position] == "")
                {
                    answer.Append(list[j]);
                    j++;
                }

            }
            return answer.ToString();
        }
    }
}

