using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;
using BookNook.DomainModel.Repositories;
using BookNook.Base;

namespace BookNook.MemoryBasedDAL
{
    public class ReadRepository : Subject, IReadRepository
    {
        private List<BookRead> _listBooks = new List<BookRead>();
        private int _lastId = -1;
        private static ReadRepository _instance;

        public static ReadRepository getInstance()
        {
            return _instance ?? (_instance = new ReadRepository());
        }

        public List<BookRead> getListBooksRead()
        {
            return _listBooks;
        }

        public int getLastId()
        {
            return _lastId;
        }

        public void AddBookRead(BookRead bookRead)
        {
            bookRead._bookId = ++_lastId;

            _listBooks.Add(bookRead);

            NotifyObservers();
        }

        public void RemoveBookRead(int bookId)
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

        public int getReadBooksNum()
        {
            return _listBooks.Count;
        }
    }
}
