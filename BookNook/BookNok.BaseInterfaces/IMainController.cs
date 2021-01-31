using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.Base
{
    public interface IMainController
    {
        void AddBookRead();
        void AddBookTBR();
        void AddBookOwned();
        void AddBookLibrary();
        void AddBookWishlist();

    }
}
