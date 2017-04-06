using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Hello
    {
        private static List<String> list = new List<String>();
        private static String choice;
        public static void Main(String[] args)
        {
            makeChoice();
            if (choice.Contains("yes"))
            {
                makeChoice();
            }
            if (choice.Contains("no"))
            {
                foreach (String i in list)
                {
                    foreach (String o in i.Split(' '))
                    {
                        Console.WriteLine(o);
                    }
                }
            }
            Console.Read();
        }
        public static void makeChoice()
        {
            Console.WriteLine("Enter a sentence:");
            list.Add(Console.ReadLine());
            Console.WriteLine("Do you want to enter another sentence?");
            choice = Console.ReadLine();
            choice = choice.ToLower();
        }
    }
}