using Generics;

class Program
{
    public static void Main()
    {

        //MyStack
        MyStack<int> stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(12);
        Console.WriteLine(stack.Count());
        Console.WriteLine(stack.Pop());
        //MyList
        MyList<int> list = new MyList<int>();
        list.Add(2);
        list.InsertAt(10, 0);
        Console.WriteLine(list.Contains(10));
        Console.WriteLine(list.Find(1));
        list.DeleteAt(0);
        list.Clear();
        
    }
}
