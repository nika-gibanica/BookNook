using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel.Factories
{
    public class BookFactory
    {
        public static BookRead CreateBookRead(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, DateTime dateRead, int rating)
        {
            return new BookRead(title, author, publisher, datePublished, numPages, genre, dateRead, rating);
        }

        public static BookTBR CreateBookTBR(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, string recommendedBy)
        {
            return new BookTBR(title, author, publisher, datePublished, numPages, genre, recommendedBy);
        }
        public static BookLibrary CreateBookLibrary(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, DateTime dateBorrowed, DateTime dueDate, string library)
        {
            return new BookLibrary(title, author, publisher, datePublished, numPages, genre, dateBorrowed, dueDate, library);
        }
        public static BookOwned CreateBookOwned(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, decimal price, string placeBought, bool read)
        {
            return new BookOwned(title, author, publisher, datePublished, numPages, genre, price, placeBought, read);
        }
        public static BookWishlist CreateBookWishlist(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, decimal price)
        {
            return new BookWishlist(title, author, publisher, datePublished, numPages, genre, price);
        }
    }
}
