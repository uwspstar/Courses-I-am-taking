using System;
using System.Collections.Generic;

namespace _003_泛型List类_Part_2_
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Book(int id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"id = {this.Id}, name = {this.Name}, price = {this.Price}";
        }
    }
    class Program
    {
        private const int V = 5;

        static void Test1()
        {

            List<int> list = new List<int>() { 1, 2, 3, 4 };
            var seg = list.GetRange(1, 2);
            Console.WriteLine(String.Join(",", seg));
            System.Console.WriteLine(String.Join(",", list));
        }
        static void Test2()
        {

            List<int> list = new List<int>() { 1, 2, 3, 4 };
            List<Book> bookList = new List<Book>() { };
            for (int i = 1; i < 10; i++)
            {
                bookList.Add(new Book(i, $"book{i}", 10 * i));
            }
            System.Console.WriteLine(String.Join(",", bookList));
            var seg = list.GetRange(1, 2);
            Console.WriteLine(String.Join(",", seg));
            System.Console.WriteLine(String.Join(",", list));
        }
        static void Main(string[] args)
        {
            Test2();
            Test1();
        }
    }
}
