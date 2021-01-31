using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel.Repositories
{
    public interface IWishlistRepository
    {
        List<BookWishlist> getListBooksWishlist();
        int getLastId();

        void AddBookWishlist(BookWishlist bookWishlist);
        void RemoveBookWishlist(int bookId);
        int getWishlistBooksNum();

    }
}
