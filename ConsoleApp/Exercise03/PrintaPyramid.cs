using System;
namespace Exercise03
{
	public class PrintaPyramid
	{
		public void Print(int layer)
		{
			int total = 2 * layer - 1;
			int space = layer - 1;
			for (; space >= 0; space--)
			{
				string sp = "";
				for (int i = 0; i < space; i++)
				{ sp += " "; }
                string star = "";
                for (int i = 0; i < total - 2*space; i++)
                { star += "*"; }
				Console.WriteLine(sp + star + sp);
			}
		}
	}
}

