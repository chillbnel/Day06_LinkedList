using System;
using Day06_LinkedList.Classes;

namespace Day06_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(7);

            LList myAwesomeList = new LList(node1);

            myAwesomeList.Print();
        }
    }
}
