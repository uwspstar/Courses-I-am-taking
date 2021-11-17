using System;

namespace _003_泛型List类_Part_2_
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
