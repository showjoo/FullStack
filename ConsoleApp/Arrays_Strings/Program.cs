using System;
using Arrays_Strings;

class Program
{
    public static void Main()
    {
        // Arrays
        //problem 1 copy arr
        CopyArray ca = new CopyArray();
        int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] arr2 = ca.copy(arr1);
        //problem 2 manage elements
        ManageElements me = new ManageElements();
        me.manage();
        //problem 3
        int[] arr3 = FIndPrime.FindPrimesInRange(3, 20);
        Console.WriteLine("[{0}]", string.Join(',', arr3));
        //problem 4
        int[] arr4 = { 1, 2, 3, 4, 5 };
        int[] res = RotateArray.rotate(arr4, 2);
        Console.WriteLine("[{0}]", string.Join(',', res));
        //problem 5
        int[] arr5 = { 1, 2, 3, 4, 5, 1, 3, 1, 4, 3, 2, 2, 2, 3, 4, 5 };
        LongestSequence.sequence(arr5);
        //problem 7
        Console.WriteLine(MostFreq.GetNum(arr5));
        //Strings
        //problem 1
        string s = "ABDSFM";
        ReverseString.Reverse1(s);
        ReverseString.Reverse2(s);
        //problem 2
        string s2 = "C# is not C++, and PHP is not Delphi!";
        string r_s2 = ReverseWords.Reverse(s2);
        Console.WriteLine(r_s2);
        //problem 3
        string s3 = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
        ExtractPalindromes.extract(s3);
        //problem 4
        string url = "ftp://www.example.com/employee";
        ParsingURL.Parse(url);

    }
}