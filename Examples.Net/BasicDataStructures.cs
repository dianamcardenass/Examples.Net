using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Examples.Net
{
    public class BasicDataStructures
    {
        public void ArrayList()
        {
            Console.WriteLine("******** ARRAYLIST ********");
            var arlist1 = new ArrayList();

            var arlist2 = new ArrayList()
                    {
                        1, "Bill", " ", true, 4.5, null
                    };

            arlist2.Add("OTHER");
            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            arlist1.AddRange(arr); //adding array in arraylist 
            arlist1.AddRange(myQ); //adding Queue in arraylist 

            Console.WriteLine("My ArrayList2");
            foreach (var item in arlist2)
            {
                Console.WriteLine(item);
            }

            //EL INSERT MUEVE TODO UNA POSICION.
            arlist1.Insert(1, "second Item");
            Console.WriteLine("My ArrayList1");
            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);
        }

        public void Array()
        {
            Console.WriteLine("******** ARRAY (obsolete?) ********");
            // integer arrays
            int[] numbers = new int[10];
            numbers[0] = 100;
            numbers[1] = 200;
            
            //string arrays
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine(weekDays[0]);
            Console.WriteLine($"lengt int array: {numbers.Length} and data of index 8: {numbers[8]}");

            var data = weekDays.AsQueryable();
            Console.WriteLine(string.Format($"arrar weekDays as Queryable: {data.FirstOrDefault(f => f.Contains("S"))}"));
        }

        public void List()
        {
            Console.WriteLine("******** LIST ********");
            List<string> Food = new List<string>();
            Food.Add("Orange");
            Food.AddRange(new List<string>() { "Apple", "Banana", "Watermelon" });

            Console.WriteLine(string.Format($"element with letter B: {Food.FirstOrDefault(f => f.Contains("B"))}"));
            Console.WriteLine(string.Format($"element with letter C: {Food.FirstOrDefault(f => f.Contains("C"))}"));
            Console.WriteLine(string.Format($"element with letter X: {Food.SingleOrDefault(f => f.Contains("X"))}"));

            try
            {
                //if element does not exists an excpetion is trhown;
                //var data = Food.First(f => f.Contains("C"));
                var data = Food.Single(f => f.Contains("C"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Element not found: {0}", ex.Message));
            }

            try
            {
                // if there are more than 1 element exception
                Console.WriteLine(string.Format($"element with letter X: {Food.SingleOrDefault(f => f.Contains("a"))}"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error: {0}", ex.Message));
            }
        }

        // Lists are fast when you need to access an element by index, 
        // Searching for an item in a list is slow since it requires a linear search
        public void ListWithInitialSize()
        {
            Console.WriteLine("******** LIST WITH SIZE ********");
            var list = new List<int>(2);

            list.Add(4);
            list.Insert(0, 7); // INSERT NUMBER 7 BEFORE 4

            try
            {
                list.Insert(4, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
          
            list.Remove(1);

            Console.WriteLine($"First element: {list[0]}");
            Console.WriteLine($"get element by index (4): {list.IndexOf(4)}");
            Console.WriteLine($"get element by index (0): {list.IndexOf(0)}");

            list.AddRange(new List<int>() { 2, 3, 4, 5 });
            // Iterate over all objects in a list
            Console.WriteLine("Capacity Is: " + list.Capacity);
            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + list.Count);

            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
