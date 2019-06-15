using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    class ObjCompare : IComparer
    {
        public enum ComparisonType
        {
            title, author, publisher, isbn, year
        }

        private ComparisonType compMethod;
        public ComparisonType ComparisonMethod
        {
            get { return compMethod; }
            set { compMethod = value; }
        }
        public int Compare(object x, object y)
        {
            Book b1 = (Book)x;
            Book b2 = (Book)y;
            return b1.CompareTo(b2, ComparisonMethod, b1);
        }
    }
}
