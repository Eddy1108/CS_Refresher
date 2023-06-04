using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Refresh1
{
    internal class Book
    {
        public string mTitle;
        public string mAuthor;
        public int mPages;

        private string rating;

        public static int booksMade = 0;
        //Static variables are variables for the class itself, not the individual objects made from it.

        public Book(string title, string author, int pages)
        {
            mTitle = title;
            mAuthor = author;
            mPages = pages;


            booksMade++;
        }

        public bool HasManyPages()
        {
            if (mPages >= 1000)
                return true;
            else
                return false;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                    rating = value;
                else
                    rating = "NR";
            }
        }
    }
}
