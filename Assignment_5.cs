using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_FullStack
{
    internal class Assignment_5
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.INPUT();
            book.PURCHASE();
            Console.ReadLine();
        }
    }
    class Book
    {
        public int BOOKNO;
        public string BOOKTITLE;
        public float PRICE;

        public void INPUT()
        {
            Console.Write("Enter Book Number: ");
            BOOKNO = int.Parse(Console.ReadLine());
            Console.Write("Enter Book Title: ");
            BOOKTITLE = Console.ReadLine();
            Console.Write("Enter  Book Price: ");
            PRICE = int.Parse(Console.ReadLine());
        }

        public void PURCHASE()
        {
            Console.Write("Enter the number of copies to be purchased: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Total cost to be paid: {0}", TOTALCOST(n));
        }
        public float TOTALCOST(int n)
        {
            return PRICE * n;
        }
    }
}
    

