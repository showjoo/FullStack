using System;
using System.Xml.Linq;

namespace Generics
{
    public class MyList<T>
    {
        private T[] list;
        private int size = 0; // count(),cur_empty_index
        private int capacity;

        public MyList(int capacity = 100)
        {
            this.capacity = capacity;
            list = new T[capacity];
        }
        public void Add(T element)
        {
            if (isFull())
                Console.WriteLine("Can't add to a full list.");
            else
            {
                list[size] = element;
                size += 1;
            }
        }
        public T Remove()
        {
            if (isEmpty())
            {
                Console.WriteLine("Can't remove from a empty list.");
                return default(T);
            }
            else
            {
                T res = list[size];
                list[size] = default(T);
                size -= 1;
                return res;
            }
        }
        public bool Contains(T element)
        {
            for (int i = 0; i < size; i++)
            {
                if (list[i].Equals(element))
                    return true;
            }
            return false;
        }
        public void Clear()
        {
            list = new T[capacity];
            size = 0;
        }
        public void InsertAt(T element, int index)
        {
            T temp;
            T previous = element;
            if (isFull())
                Console.WriteLine("Can't add to a full list.");
            else
            {
                if (index <= size && index >= 0)
                {
                    for (int i = index; i <= size; i++)
                    {
                        temp = list[i];
                        list[i] = previous;
                        previous = temp;
                    }
                    size += 1;
                }
                else
                {
                    Console.WriteLine("Index out of range!");
                }
            }
        }
        public void DeleteAt(int index)
        {
            if (isEmpty())
                Console.WriteLine("Can't delete from an empty list.");
            else
            {
                if (index <= size && index >= 0)
                {
                    for (int i = index; i < size-1; i++)
                    {
                        list[i] = list[i + 1];
                    }
                    list[size - 1] = default(T);
                    size -= 1;
                }
                else
                {
                    Console.WriteLine("Index out of range!");
                }
            }
        }
        public T Find(int index)
        {
            if (index < size && index >= 0)
                return list[index];
            else
            {
                Console.WriteLine("Index out of range!");
                return default(T);
            }

        }
        public bool isFull()
        {
            if (size == capacity)
            {
                return true;
            }
            else
                return false;
        }
        public bool isEmpty()
        {
            if (size == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}

