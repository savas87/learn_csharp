using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list
            List<int> zahlenList = new List<int>();

            // add val to list
            zahlenList.Add(1);
            zahlenList.Add(2);
            zahlenList.Add(3);

            // loop the list
            for (int i= 0; i < zahlenList.Count; i++)
            {
                Console.WriteLine(zahlenList[i]);
            }
            Console.WriteLine("---------------");

            // remov val from list
            zahlenList.RemoveAt(1);
            
            // write new list
            foreach(int zahl in zahlenList)
            {
                Console.WriteLine(zahl);
            }
            Console.WriteLine("-----------");
            // create a new stack
            Stack();
            Console.ReadKey();
        }

        static void Stack()
        {
            // create a new stack
            Stack<int> zahlenStapel = new Stack<int>();

            // put new val at first place on the top
            zahlenStapel.Push(1);
            zahlenStapel.Push(2);
            zahlenStapel.Push(3);

            // read and delete
            Console.WriteLine(zahlenStapel.Pop());
            Console.WriteLine(zahlenStapel.Peek());
            Console.WriteLine(zahlenStapel.Peek());
        }

       
    }
}
