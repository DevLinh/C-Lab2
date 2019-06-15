using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    class Program
    {
        static void Main(string[] args)
        {
            BookList bl = new BookList();
            // Write out a header for the output.
            Console.WriteLine("Array - Unsorted\n");
            Book b1 = new Book("x", "x", "x", "x", 2000);
            bl.Add(b1);
            Book b2 = new Book("a", "x", "x", "x", 2019);
            bl.Add(b2);
            Book b3 = new Book("e", "x", "x", "x", 2001);
            bl.Add(b3);
            Book b4 = new Book("b", "x", "x", "x", 2000);
            bl.Add(b4);
            Book b5 = new Book("x", "x", "x", "x", 2002);
            bl.Add(b5);
            bl.ShowList();
            Console.WriteLine("-------------------------------------------------");
            //sorting
            bl.sortBookList("title");

            Console.ReadLine();
        }
    }
}
