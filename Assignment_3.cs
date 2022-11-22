using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_FullStack
{
    internal class Assignment_3
    {
        public static int SpaceCount(string str)
        {
            int spc = 0;
            string str_1;
            for (int i = 0; i < str.Length; i++)
            {
                str_1 = str.Substring(i, 1);
                if (str_1 == " ")
                    spc++;
            }
            return spc;
        }
        public static void Main()
        {
            string str_2;
            Console.Write(" Enter a string : ");
            str_2 = Console.ReadLine();
            Console.WriteLine("\"" + str_2 + "\"" + " contains {0} spaces", SpaceCount(str_2));

            Console.ReadLine();


        }
    }
}

    

