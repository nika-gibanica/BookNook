using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;

namespace BookNook.Base
{
    public interface IShowTBRBookListView
    {
        void ShowModaless(IMainController inMainController, List<BookTBR> inListBook);
    }
}
