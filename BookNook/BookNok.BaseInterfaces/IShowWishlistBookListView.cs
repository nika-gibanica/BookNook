using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;

namespace BookNook.Base
{
    public interface IShowWishlistBookListView
    {
        void ShowModaless(IMainController inMainController, List<BookWishlist> inListBook);
    }
}
