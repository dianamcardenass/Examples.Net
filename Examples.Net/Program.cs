using DataStructures;
using System;

namespace Examples.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================================");
            Console.WriteLine("BASIC DATA STRUCTURES");
            Console.WriteLine("============================================");
            var dataStructures = new BasicDataStructures();
            dataStructures.Array();
            dataStructures.List();
            dataStructures.ArrayList();
            dataStructures.ListWithInitialSize();

            Console.WriteLine("============================================");
            Console.WriteLine("OTHER DATA STRUCTURES");
            Console.WriteLine("============================================");
            var complexDT = new ComplexDS();
            complexDT.Dictionary();
            complexDT.HashSet();
            complexDT.Stack();
            complexDT.Queue();
            Console.ReadLine();
        }
    }
}
