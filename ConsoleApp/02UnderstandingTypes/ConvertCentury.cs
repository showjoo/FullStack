using System;
namespace _02UnderstandingTypes
{
	public class ConvertCentury
	{
        public void convert(int a)
        {
            int year = a * 100;
            int days = year * 365 + year / 4;
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long mill = seconds * 1000;
            long micro = mill * 1000;
            ulong nano = (ulong)micro * 1000;
            Console.WriteLine($"{a} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {mill} milliseconds = {micro} microseconds = {nano} nanoseconds");
        }
	}
}

