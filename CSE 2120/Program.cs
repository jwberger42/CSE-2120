using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_2120
{
    class Program
    {
        private static String input;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words:");
            input = Console.ReadLine();
            Storage.Store(input);
            Storage.Call(false);
            Console.WriteLine("Enter another sentence for word use comparison:");
            input = Console.ReadLine();
            Storage.Store(input);
            Storage.Call(true);
            Console.Read();
        }
    }
}
