using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel.Repositories
{
    public interface IReadRepository
    {
        List<BookRead> getListBooksRead();
        int getLastId();
        void AddBookRead(BookRead bookRead);
        void RemoveBookRead(int bookId);
        int getReadBooksNum();

    }
}
