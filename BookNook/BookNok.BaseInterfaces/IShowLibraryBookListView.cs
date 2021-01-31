using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;

namespace BookNook.Base
{
    public interface IShowLibraryBookListView
    {
        void ShowModaless(IMainController inMainController, List<BookLibrary> inListBook);
    }
}
