using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Vide_67_Searching_a_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); // create a new list
            BuildList(numbers); // call the random num gen  method and populate into list numbers
            Display(numbers); // calls the display numbers method
            int item;
            Console.WriteLine();
            Console.WriteLine("Enter an item: ");
            item = Convert.ToInt32(Console.ReadLine());
            if (numbers.Contains(item))
            {
                Console.WriteLine(item + " The item is at position " + numbers.IndexOf(item)); // prints item and indexOf prints locations of item
            }
            static void Display(List<int> lyst) // displays the random number generators and adds a space every 25th line
            {
                for (int i = 0; i < lyst.Count; ++i) 
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(lyst[i] + " ");
                    }
                }
            }
            static void BuildList(List<int> lyst)
            {
                Random rand = new Random();
                for (int i = 0; i < 100; ++i)
                {
                    lyst.Add(rand.Next(1, 101));
                }
            }
        }
    }
}
