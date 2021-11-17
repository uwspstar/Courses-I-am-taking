using System;
using System.Collections.Generic;
//https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-5.0

namespace _002_泛型List类_Part_1_
{
    class Program
    {

        static void Test1()
        {

            List<int> list = new List<int>();

            Console.WriteLine($"list.Count = {list.Count}");
            Console.WriteLine($"list.Capacity = {list.Capacity}");
            System.Console.WriteLine(String.Join(",", list));
        }

        static void Test2()
        {
            int[] arr = new int[] { 100, 200, 300, 400 };
            List<int> list = new List<int>(arr);
            System.Console.WriteLine(arr is IEnumerable<int>);
            String res = String.Join(",", list);
            System.Console.WriteLine($"res = {res}");
        }
        static void Test3()
        {
            List<int> list = new List<int>(50);
            Console.WriteLine($"list.Count = {list.Count}");
            Console.WriteLine($"list.Capacity = {list.Capacity}");
        }

        static void Test4()
        {
            List<int> list = new List<int>() {1, 2, 3, 4};
            List<int> list2 = new List<int>() {10, 20, 30, 40};
            list2.AddRange(list);
            Console.WriteLine($"list2.AddRange :");
            System.Console.WriteLine(String.Join(",", list2));
            list2.InsertRange(2,list);
            System.Console.WriteLine(String.Join(",", list2));
        }
        static void Main(string[] args)
        {
            Test4();
            Test3();
            Test2();
            Test1();
        }
    }
}

/*
List<T>(IEnumerable<T>)
*/