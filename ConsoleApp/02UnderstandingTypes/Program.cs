// See https://aka.ms/new-console-template for more information

using _02UnderstandingTypes;

class Program
{
    public static void Main()
    {
        //problem 1
        Console.WriteLine("Type, Size, Min, Max");
        Console.WriteLine("{0},{1},{2},{3}", typeof(sbyte), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(byte), sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(short), sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(ushort), sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(int), sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(uint), sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(long), sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(ulong), sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(float), sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(double), sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0},{1},{2},{3}", typeof(decimal), sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        //problem 2
        ConvertCentury cc = new ConvertCentury();
        cc.convert(5);
    }
}