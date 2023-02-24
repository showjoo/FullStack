using System;
namespace Generics
{
	public class MyStack<T>
	{
		public int Capacity { get; set; }
		private int _top=0;
		T[] stack;
		public MyStack(int capacity = 100)
		{
			Capacity = capacity;
            stack = new T[capacity];
        }
		public int Count()
		{
			return _top;
		}
        public T Pop()
        {
			if (_top == 0)
			{
				Console.WriteLine("Can't pop a empty stack!");
				return default(T);
			}
			else
			{
				T popElement = stack[_top - 1];
				_top = _top - 1;
				return popElement;
            }
        }
        public void Push(T element)
        {
			if (_top == Capacity)

			{
				Console.WriteLine("Can't push to a full stack!");
			}
			else
			{
                stack[_top] = element;
                _top += 1;
            }
        }
    }
}

