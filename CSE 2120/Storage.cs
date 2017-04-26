using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE_2120
{
    class Storage
    {
        static ArrayList al = new ArrayList();
        static ArrayList last = new ArrayList();
        private static int counter = 0;
        public static void Store(String input)
        {
            foreach (String i in input.Split(' '))
            {
                //Add splitted strings
                al.Add(i);
            }
        }
        public static void Call(bool first)
        {
            //This prints data first and side by side to compare and stuff
            if (first)
            {
                foreach (String i in al)
                {
                    Console.WriteLine(i + "\t" + last[counter]);
                    last.Add(i);
                    counter++;
                }
            }
            if (!first)
            {
                foreach (String i in al)
                {
                    Console.WriteLine(i);
                    last.Add(i);
                }
                al.Clear();
            }
            
        }
    }
}
