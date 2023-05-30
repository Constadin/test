using System;
using System.Collections;
using System.Collections.Generic;

namespace stack_q
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STACK");

            Stack my_stack = new Stack();

            Random rand = new Random();

            my_stack.Push(0);

            for (int i = 0; i < 5; i++)
            {
                int randomValue = rand.Next(100);
                my_stack.Push(randomValue);
            }

            Console.WriteLine("Stack elements:");

            foreach (int element in my_stack)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Topmost element of my_stack"
                          + " is: {0}", my_stack.Pop());

            Console.WriteLine("Stack elements after pop:");

            //Console.WriteLine("Topmost element of my_stack " +
            // "is: {0}", my_stack.Peek());

            foreach (int element in my_stack)
            {
                Console.WriteLine(element);
            }

            Queue my_queue = new Queue();

            Console.WriteLine("Queue elements:");

            for (int i = 0; i < 5; i++)
            {
                int randomValue = rand.Next(100);
                my_queue.Enqueue(randomValue);
            }

            // Obtain the topmost element of my_queue
            // Using Dequeue method


            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}", my_queue.Dequeue());

            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }

            List <string> mylist = new List<string>();

            mylist.Add("banana");
            mylist.Add("apple");
            mylist.Add("cherry");
            mylist.Add("mango");
            mylist.Add("mellon");

            Console.WriteLine("\nList elements:");

            foreach (string element in mylist)
            {
                Console.WriteLine(element);
            }

            mylist.Sort();
            mylist.RemoveRange(2,1);

            mylist.Remove("apple");

            // mylist.Insert(3, "orange");

            Console.WriteLine("\nList elements after:");
            foreach (string element in mylist)
            {
                Console.WriteLine(element);
            }

            List<string> list_all = new List<string>();
            //list_all = ["list1",["lsit2.1","list2.2"],["list3.1","list3.2"]];

            Console.WriteLine("\nList to list:");
            foreach (string list in list_all)
            {
                Console.WriteLine(list);
            }
        }
    }
}