using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_FullStack
{
    internal class Assignment_1
    {
        static void Main (string[] args)
        {
            Student myObj1 = new Student(1);
            Student myObj2 = new Student(2);
            Console.WriteLine("Call by first instance");
            myObj1.displaydetails();
            Console.WriteLine("Call by second instance");
            myObj2.displaydetails();
        }
    }
    public class Student
    {

        int rollno;
        string name;

        public Student(int i)
        {
            Console.WriteLine("Enter Name of Student{0}", i);
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Roll Number of Student{0}", i);
            rollno = Convert.ToInt32(Console.ReadLine());
            i++;

        }
        public void displaydetails()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("rollno :" + rollno);


        }


    }
}


