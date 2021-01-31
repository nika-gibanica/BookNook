using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel
{
    public class BookOwned : Book
    {
        protected DateTime dateBougth;
        protected decimal price;
        protected string placeBought;
        protected bool read;

        public BookOwned(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, decimal price, string placeBought, bool read)
        {
            _title = title;
            _author = author;
            _publisher = publisher;
            _datePublished = datePublished;
            _numPages = numPages;
            _genre = genre;
            this.price = price;
            this.placeBought = placeBought;
            this.read = read;
        }

        public DateTime DateBougth
        {
            get { return dateBougth; }
            set { dateBougth = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string PlaceBought
        {
            get { return placeBought; }
            set { placeBought = value; }
        }

        public bool Read
        {
            get { return read; }
            set { read = value; }
        }

    }
}
