using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class ComplexDS
    {
        //fast lookups 
        public void Dictionary()
        {
            Console.WriteLine("******** DICTIONARY - KEY IS UNIQUE ********");
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); 
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            var cities = new Dictionary<string, string>(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }

        public void HashSet()
        {
            Console.WriteLine("******** HashSet ********");
            var hashSet = new HashSet<int>() { 1, 2, 3 };
            hashSet.Add(4);
            hashSet.Remove(3);
            hashSet.Clear();

            Console.WriteLine($"Contains element 1: {hashSet.Contains(1)}");
            Console.WriteLine($"size: {hashSet.Count}");

            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(1); // it is not icnluded twice...
            Console.WriteLine($"Contains element 1: {hashSet.Contains(1)}");
            Console.WriteLine($"size: {hashSet.Count}");
            foreach (var value in hashSet)
                Console.WriteLine("Value: {0}", value);
        }

        //LIFO (Last-In-First-Out)
        public void Stack()
        {
            Console.WriteLine("******** STACK ********");
            var stack = new Stack<string>();
            stack.Push("diana");
            stack.Push("marcela");
            stack.Push("andres");
            stack.Push("camilo");
            stack.Push("julian");
            var contains = stack.Contains("diana");
            Console.WriteLine($"stack contains 'diana'?: {contains}");
            var pop = stack.Pop();
            Console.WriteLine($"pop value: {pop}");
            var peek = stack.Peek();
            Console.WriteLine($"peek value: {peek}");
            var count = stack.Count;
            Console.WriteLine($"count: {count}");
            stack.Clear();
        }

        // (First-In-First-Out)
        public void Queue()
        {
            Console.WriteLine("******** QUEUE ********");
            var queue = new Queue<string>();
            queue.Enqueue("Message1");
            var contains = queue.Contains("Message1");
            var front = queue.Dequeue();
            var top = queue.Peek();
            queue.Clear();
            var count = queue.Count;
        }
    }
}
