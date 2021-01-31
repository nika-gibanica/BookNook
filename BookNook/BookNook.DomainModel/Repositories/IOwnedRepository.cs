using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel.Repositories
{
    public interface IOwnedRepository
    {
        List<BookOwned> getListBooksOwned();
        int getLastId();
        void AddBookOwned(BookOwned bookOwned);
        void RemoveBookOwned(int bookId);
        int getOwnedBooksNum();

    }
}
