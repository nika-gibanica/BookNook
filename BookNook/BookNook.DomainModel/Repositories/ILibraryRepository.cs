using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel.Repositories
{
    public interface ILibraryRepository
    {

        List<BookLibrary> getListBooksLibrary();
        int getLastId();
        void AddBookLibrary(BookLibrary bookLibrary);
        void RemoveBookLibrary(int bookId);
        int getLibraryBooksNum();
    }
}
