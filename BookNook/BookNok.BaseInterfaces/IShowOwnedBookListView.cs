using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;

namespace BookNook.Base
{
    public interface IShowOwnedBookListView
    {
        void ShowModaless(IMainController inMainController, List<BookOwned> inListBook);
    }
}
