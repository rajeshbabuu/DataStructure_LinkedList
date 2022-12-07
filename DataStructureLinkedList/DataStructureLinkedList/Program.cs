using System.Collections.Generic;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* WELCOME TO DATASTRUCTURE LINKEDLIST PROGRAM ***********************");
            LinkedList l_Object = new LinkedList();
            l_Object.add(56);
            l_Object.add(30);
            l_Object.add(70);
            l_Object.SearchNode(70);
            l_Object.display();
        }
    }
}