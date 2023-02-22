// See https://aka.ms/new-console-template for more information
using Exercise03;

class Program
{
    public static void Main()
    {
        //problem 1 fizzbuzz
        FizzBuzz fb = new FizzBuzz();
        fb.simulate(100);
        //problem 2 pyramid
        PrintaPyramid pap = new PrintaPyramid();
        pap.Print(7);
        //problem 3 guessnumber
        GuessNumber gn = new GuessNumber();
        gn.guess();
        //problem 4 age
        Age a = new Age();
        DateTime dob = new DateTime(1998, 8, 24);
        Console.WriteLine(a.CalculateAge(dob));
        //problem 5 Greet
        Greet g = new Greet();
        g.Greets(DateTime.Now);
        //problem 6 Count24
        Counting24 ct = new Counting24();
        ct.count();
    }
}