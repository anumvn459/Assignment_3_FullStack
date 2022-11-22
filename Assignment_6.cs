using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_FullStack
{
    internal class Assignment_6
    {
        static void Main(string[] args)
        {
            student s = new student();
            Console.WriteLine("Enter number of Students");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s.read();
                s.calculate();
                s.display();
            }

        }
    }
    public class student
    {
        int i = 1;
        int id;
        string name;
        int[] mark = new int[3];
        int total;
        public void read()
        {
            Console.WriteLine("Enter student {0} details", i);
            Console.WriteLine("Enter Student Id :");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Marks of 3 Subjects outof 10");
            Console.WriteLine("Enter Mark of Subject 1 :");
            mark[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark of Subject 2 :");
            mark[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark of Subject 3 :");
            mark[2] = Convert.ToInt32(Console.ReadLine());
        }
        public void calculate()
        {
            total = mark[0] + mark[1] + mark[2];
        }
        public void display()
        {
            Console.WriteLine("Student {0} details", i);
            Console.WriteLine("Student Id is :" + id);
            Console.WriteLine("Student Name is :" + name);
            Console.WriteLine("Mark of Subject 1 :" + mark[0]);
            Console.WriteLine("Mark of Subject 2:" + mark[1]);
            Console.WriteLine("Enter Mark of Subject 3 :" + mark[2]);
            Console.WriteLine("Total marks in 3 Subjects  :" + total);
            i++;
        }
    }
}
    

