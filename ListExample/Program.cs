using System;
using System.Collections.Generic;

namespace ListExample
{
    internal class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>() { 10,20,30};
            myList.Add(40);
            List<int> myList2=new List<int>() { 50,60,70,80};
            myList.AddRange(myList2);
            myList.Insert(2, 100);
            myList.InsertRange(3, myList2);
            
            myList.Remove(50);
            myList.RemoveAt(0);
            myList.RemoveRange(0, 4);
            //myList.Clear();
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            
            List<int> myList3 = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine(myList3.IndexOf(1));
            Console.WriteLine(myList3.BinarySearch(2));
            Console.WriteLine(myList3.Contains(1));
            List<int> myList4 = new List<int>() { 1, 3, 2, 4 };
            myList4.Sort();
            myList4.Reverse();
            foreach (int i in myList4)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
