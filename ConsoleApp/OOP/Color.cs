using System;
namespace OOP
{
	public class Color
	{
		public double Red { get; set; }
        public double Blue { get; set; }
        public double Green { get; set; }
        public double Alpha { get; set; }
        public Color(double red,double blue,double green,double alpha)
		{
			Red = red;
			Blue = blue;
			Green = green;
			Alpha = alpha;
		}
        public Color(double red, double blue, double green)
        {
            Red = red;
            Blue = blue;
            Green = green;
            Alpha = 255.0;
        }
        public double GetGrayScale()
		{
			return (Red + Blue + Green) / 3;
		}
	}
}

