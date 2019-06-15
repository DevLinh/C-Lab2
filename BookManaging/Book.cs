using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    class Book : IBook
    {
        #region define data components

        private string title;
        private string author;
        private string publisher;
        private string isbn;
        private int year;

        private ArrayList chapter = new ArrayList();

        public Book(string title, string author, string publisher, string isbn, int year)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.isbn = isbn;
            this.year = year;
        }

        public Book()
        {
            this.title = "";
            this.author = "";
            this.publisher = "";
            this.isbn = "";
            this.year = 2000;
        }

        #endregion


        #region implement IBook
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string ISBN { get => isbn; set => isbn = value; }
        public int Year { get => year; set => year = value; }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public void Show()
        {
            Console.Write(String.Format("{0, -30}| {1, -30}| {2, -30}| {3, -10}| {4, -20}|", title, author, publisher, year, isbn));
            for (int i = 0; i < chapter.Count; i++)
                Console.Write(" {0}: {1} /", i + 1, chapter[i]);
        }

        public void Input()
        {
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author= Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input chapter (finished with empty string)");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);
        }
        #endregion

        public int CompareTo(Book b2, ObjCompare.ComparisonType comparisonType, Book b1)
        {
            int returnValue = 0;
            switch(comparisonType)
            {
                case ObjCompare.ComparisonType.title:
                    if (b1.title == b2.title)
                        returnValue = year.CompareTo(b2.year);
                    else
                        returnValue = title.CompareTo(b2.title);
                    break;
                case ObjCompare.ComparisonType.year:
                    if (b1.year == b2.year)
                        returnValue = title.CompareTo(b2.title);
                    else
                        returnValue = year.CompareTo(b2.year);
                    break;
            }
            return returnValue;
        }
        
    }
}
