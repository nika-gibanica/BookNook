using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;
using BookNook.DomainModel.Repositories;
using BookNook.Base;

namespace BookNook.MemoryBasedDAL
{
    public class OwnedRepository : Subject, IOwnedRepository
    {
        private List<BookOwned> _listBooks = new List<BookOwned>();
        private int _lastId = -1;
        private static OwnedRepository _instance;

        public static OwnedRepository getInstance()
        {
            return _instance ?? (_instance = new OwnedRepository());
        }

        public List<BookOwned> getListBooksOwned()
        {
            return _listBooks;
        }

        public int getLastId()
        {
            return _lastId;
        }

        public void AddBookOwned(BookOwned bookOwned)
        {
            bookOwned._bookId = ++_lastId;

            _listBooks.Add(bookOwned);

            NotifyObservers();
        }

        public void RemoveBookOwned(int bookId)
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

        public int getOwnedBooksNum()
        {
            return _listBooks.Count;
        }
    }
}
