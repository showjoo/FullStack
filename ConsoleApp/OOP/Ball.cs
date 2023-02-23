using System;
namespace OOP
{
	public class Ball
	{
        public int Size { get; set; }
        public Color Color { get; set; }
		public int ThrowTimes { get; set; }
        public Ball(int size,Color color,int throwtimes = 0)
		{
			Size = size;
			Color = color;
			ThrowTimes = throwtimes;
		}
		public void pop()
		{
			Size = 0;
		}
        public void Throw()
        {
			if (Size != 0)
			{
				ThrowTimes += 1;
				Console.WriteLine("Throw!");
			}
			else
                Console.WriteLine("Can't Throw!");
        }
		public int ReturnThrowTime()
		{
			return ThrowTimes;
		}
    }
}

