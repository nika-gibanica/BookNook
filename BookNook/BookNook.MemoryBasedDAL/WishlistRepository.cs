using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;
using BookNook.DomainModel.Repositories;
using BookNook.Base;

namespace BookNook.MemoryBasedDAL
{
    public class WishlistRepository : Subject, IWishlistRepository
    {
        private List<BookWishlist> _listBooks = new List<BookWishlist>();
        private int _lastId = -1;
        private static WishlistRepository _instance;

        public static WishlistRepository getInstance()
        {
            return _instance ?? (_instance = new WishlistRepository());
        }

        public List<BookWishlist> getListBooksWishlist()
        {
            return _listBooks;
        }

        public int getLastId()
        {
            return _lastId;
        }

        public void AddBookWishlist(BookWishlist bookWishlist)
        {
            bookWishlist._bookId = ++_lastId;

            _listBooks.Add(bookWishlist);

            NotifyObservers();
        }

        public void RemoveBookWishlist(int bookId)
        {
            for (int i = 0; i < _listBooks.Count; i++)
            {
                if (_listBooks[i]._bookId == bookId)
                {
                    _listBooks.RemoveAt(i);
                }
            }

            NotifyObservers();
        }

        public int getWishlistBooksNum()
        {
            return _listBooks.Count;
        }
    }
}
