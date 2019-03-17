using System;
using logic;
using Wintellect.PowerCollections;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            System.Console.Write("whats your name:");
            var name = Console.ReadLine();
            var message = HelloWorld.GetMessage(name);
            System.Console.WriteLine(message);
        }

        public void Test()
        {
            var data = new Bag<int> { 1, 2, 3 };
            foreach (var item in data)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
