using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BookManaging.ObjCompare;

namespace BookManaging
{
    class BookList
    {
        private ArrayList list = new ArrayList();

        public void Add(Book b)
        {
            list.Add(b);
        }

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            Console.Write(String.Format("{0, -30}| {1, -30}| {2, -30}| {3, -10}| {4, -20}| {5, -40}\n", "title", "author", "publisher", "year", "isbn", "chapter"));
            foreach (Book b in list)
            {
                b.Show();
                Console.WriteLine("");
            }
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }

        //sort
        public void sortBookList(string x)
        {
            ObjCompare objcom = new ObjCompare();
            if ( x.Equals("title"))
                objcom.ComparisonMethod = ObjCompare.ComparisonType.title;
            else
                objcom.ComparisonMethod = ObjCompare.ComparisonType.year;
            list.Sort(objcom);
            Console.Write(" ---after sort -- \n");
            ShowList();
        }
    }
}
