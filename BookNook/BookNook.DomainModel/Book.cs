using System;

namespace BookNook.DomainModel
{
    public abstract class Book
    {
        public int _bookId;
        protected string _title;
        protected string _author;
        protected string _publisher;
        protected DateTime _datePublished;
        protected int _numPages;
        protected string _genre;

        public int BookId
        {
            get { return _bookId; }
            set { _bookId = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public DateTime DatePublished
        {
            get { return _datePublished; }
            set { _datePublished = value; }
        }

        public int NumPages
        {
            get { return _numPages; }
            set { _numPages = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

    }
}
