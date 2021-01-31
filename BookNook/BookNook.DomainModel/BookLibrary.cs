using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel
{
    public class BookLibrary : Book
    {
        protected DateTime dateBorrowed;
        protected DateTime dueDate;
        protected string library;
        protected bool returned;

        public BookLibrary(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, DateTime dateBorrowed, DateTime dueDate, string library)
        {
            _title = title;
            _author = author;
            _publisher = publisher;
            _datePublished = datePublished;
            _numPages = numPages;
            _genre = genre;
            this.dateBorrowed = dateBorrowed;
            this.dueDate = dueDate;
            this.library = library;
            this.returned = false;
            
        }

        public DateTime DateBorrowed
        {
            get { return dateBorrowed; }
            set { dateBorrowed = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public string Library
        {
            get { return library; }
            set { library = value; }
        }

        public bool Returned
        {
            get { return returned; }
            set { returned = value; }
        }

        public void Prolong(int numDays)
        {
            dueDate = dueDate.AddDays(numDays);
        }

        public void Return()
        {
            returned = true;
        }
    }
}
