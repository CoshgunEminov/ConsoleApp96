using System.Collections.Generic;

namespace ConsoleApp96
{
      public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine(stack.Peek());

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----");
            Console.WriteLine(stack.Capacity);
            Console.WriteLine(stack.Count);
        }
    }
}