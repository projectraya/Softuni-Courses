﻿namespace _06.Implementing_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new CircularQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Console.WriteLine("Count = {0}", queue.Count);
            Console.WriteLine(string.Join(", ", queue.ToArray()));
            Console.WriteLine("---------------------------");

            var first = queue.Dequeue();
            Console.WriteLine("First = {0}", first);
            Console.WriteLine("Count = {0}", queue.Count);
            Console.WriteLine(string.Join(", ", queue.ToArray()));
            Console.WriteLine("---------------------------");

            queue.Enqueue(-7);
            queue.Enqueue(-8);
            queue.Enqueue(-9);
            Console.WriteLine("Count = {0}", queue.Count);
            Console.WriteLine(string.Join(", ", queue.ToArray()));
            Console.WriteLine("---------------------------");

            first = queue.Dequeue();
            Console.WriteLine("First = {0}", first);
            Console.WriteLine("Count = {0}", queue.Count);
            Console.WriteLine(string.Join(", ", queue.ToArray()));
            Console.WriteLine("---------------------------");

            queue.Enqueue(-10);
            Console.WriteLine("Count = {0}", queue.Count);
            Console.WriteLine(string.Join(", ", queue.ToArray()));
            Console.WriteLine("---------------------------");

            first = queue.Dequeue();
            Console.WriteLine("First = {0}", first);
            Console.WriteLine("Count = {0}", queue.Count);
            Console.WriteLine(string.Join(", ", queue.ToArray()));
            Console.WriteLine("---------------------------");
        }
    }
}
