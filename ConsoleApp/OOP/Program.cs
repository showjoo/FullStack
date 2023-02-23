using OOP;

class Program
{
    public static void Main()
    {
        //problem 1
        int[] numbers = GenerateNumbers(10);
        Reverse(numbers);
        PrintNumbers(numbers);
        //problem 2
        for (int i = 1;i<=10;i++)
            Console.Write($"{Fibonacci(i)} ");
        //balls and colors
        Ball ball1 = new Ball(1, new Color(233, 217, 100));
        Ball ball2 = new Ball(2, new Color(23, 2, 10));
        ball1.Throw();
        ball1.Throw();
        ball2.Throw();
        Console.WriteLine($"Ball1's Throw Times = {ball1.ReturnThrowTime()}, " +
            $"Ball2's Throw Times = {ball2.ReturnThrowTime()} ");
        ball2.pop();
        ball1.Throw();
        ball1.Throw();
        ball2.Throw();
        Console.WriteLine($"Ball1's Throw Times = {ball1.ReturnThrowTime()}, " +
            $"Ball2's Throw Times = {ball2.ReturnThrowTime()} ");
    }
    public static int[] GenerateNumbers(int n)
    {
        var numbers = Enumerable.Range(1, n).ToArray();
        return numbers;
    }
    public static void Reverse(int[] num)
    {
        Array.Reverse(num);
    }
    public static void PrintNumbers(int[] num)
    {
        Console.WriteLine(string.Join(", ", num));
    }
    //Fibonacci Sequence
    public static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

}