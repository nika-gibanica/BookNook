using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel
{
    public class BookRead : Book
    {
        protected DateTime dateRead;
        protected int rating;

        public BookRead(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, DateTime dateRead, int rating)
        {
            _title = title;
            _author = author;
            _publisher = publisher;
            _datePublished = datePublished;
            _numPages = numPages;
            _genre = genre;
            this.dateRead = dateRead;
            this.rating = rating;
        }

        public DateTime DateRead
        {
            get { return dateRead; }
            set { dateRead = value; }
        }

        public int Rating
        {
            get { return rating; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    rating = value;
                }
            }
        }
    }
}
