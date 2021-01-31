using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;
using BookNook.DomainModel.Repositories;
using BookNook.Base;

namespace BookNook.MemoryBasedDAL
{
    public class LibraryRepository : Subject, ILibraryRepository
    {
        private List<BookLibrary> _listBooks = new List<BookLibrary>();
        private int _lastId = -1;
        private static LibraryRepository _instance;

        public static LibraryRepository getInstance()
        {
            return _instance ?? (_instance = new LibraryRepository());
        }
        public List<BookLibrary> getListBooksLibrary()
        {
            return _listBooks;
        }

        public int getLastId()
        {
            return _lastId;
        }

        public void AddBookLibrary(BookLibrary bookLibrary)
        {
            bookLibrary._bookId = ++_lastId;

            _listBooks.Add(bookLibrary);

            NotifyObservers();
        }

        public void RemoveBookLibrary(int bookId)
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

        public int getLibraryBooksNum()
        {
            return _listBooks.Count;
        }
    }
}
