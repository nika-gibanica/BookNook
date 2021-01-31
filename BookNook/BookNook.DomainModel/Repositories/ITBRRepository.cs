using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel.Repositories
{
    public interface ITBRRepository
    {

        List<BookTBR> getListBooksTBR();
        int getLastId();
        void AddBookTBR(BookTBR bookTBR);
        void RemoveBookTBR(int bookId);
        int getTBRBooksNum();

    }
}
