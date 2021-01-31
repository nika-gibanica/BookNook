using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;

namespace BookNook.Base
{
    public interface IShowReadBookListView
    {
        void ShowModaless(IMainController inMainController, List<BookRead> inListBook);
    }
}
