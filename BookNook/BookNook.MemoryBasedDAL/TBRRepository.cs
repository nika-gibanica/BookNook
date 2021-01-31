using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;
using BookNook.DomainModel.Repositories;
using BookNook.Base;

namespace BookNook.MemoryBasedDAL
{
    public class TBRRepository : Subject, ITBRRepository
    {

        private List<BookTBR> _listBooks = new List<BookTBR>();
        private int _lastId = -1;
        private static TBRRepository _instance;

        public static TBRRepository getInstance()
        {
            return _instance ?? (_instance = new TBRRepository());
        }
        public List<BookTBR> getListBooksTBR()
        {
            return _listBooks;
        }

        public int getLastId()
        {
            return _lastId;
        }

        public void AddBookTBR(BookTBR bookTBR)
        {
            bookTBR._bookId = ++_lastId;

            _listBooks.Add(bookTBR);

            NotifyObservers();
        }

        public void RemoveBookTBR(int bookId)
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

        public int getTBRBooksNum()
        {
            return _listBooks.Count;
        }
    }
}
