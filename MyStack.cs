using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp96
{
     public class MyStack<T>:IEnumerable
    {
            public T[] _arr;
            public int Count { get; private set; }
            public int Capacity { get; private set; }


            public MyStack()
            {
                Capacity = 4;
                Count = 0;
                _arr = new T[Capacity];
            }
            public MyStack(int capacity)
            {
                Capacity = capacity;
                _arr = new T[capacity];
            }
           
            public void Push(T item)
            {
                if (Count == Capacity)
                {
                    Capacity *= 2;
                    Array.Resize(ref _arr, Capacity);
                }
                _arr[Count++] = item;
            }

            public IEnumerator GetEnumerator()
            {
                for (int i = Count - 1; i >= 0; i--)
                {
                    yield return _arr[i];
                }
            }
            public void Pop()
            {
                Count--;
                if (Count <= 0)
                {
                    Console.WriteLine("There is no element to delete");
                }
                else
                {
                    Array.Resize(ref _arr, Count);
                }

            }
            public T Peek()
            {
                T lastValue = _arr[Count - 1];
                return lastValue;
            }
        }
}
