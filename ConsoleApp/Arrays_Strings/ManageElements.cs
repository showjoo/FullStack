using System;
namespace Arrays_Strings
{
	public class ManageElements
	{
		public void manage()
		{
			List<String> Items = new List<string>();
			int i = 0;
			while (i<10)
			{
				Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
				string s = Console.ReadLine();
				if (s == "quit")
				{ break; }
				if (s.Substring(0, 2) == "+ ")
				{
					Items.Add(s.Substring(2));
				}
				else if (s.Substring(0, 2) == "- ")
                {
                    Items.Remove(s.Substring(2));
                }
				else if (s.Substring(0, 2) == "--")
                {
                    Items.Clear();
                }
                Console.WriteLine("[{0}]", string.Join(", ", Items));
                i++;
			} 
        }
	}
}

