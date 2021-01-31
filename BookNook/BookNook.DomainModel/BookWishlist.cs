using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel
{
    public class BookWishlist : Book
    {
        protected decimal price;

        public BookWishlist(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, decimal price)
        {
            _title = title;
            _author = author;
            _publisher = publisher;
            _datePublished = datePublished;
            _numPages = numPages;
            _genre = genre;
            this.price = price;
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
