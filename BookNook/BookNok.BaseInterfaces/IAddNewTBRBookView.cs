using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.Base
{
    public interface IAddNewTBRBookView
    {
        bool ShowViewModal();

        string Title { get; }
        string Author { get; }
        string Publisher { get; }
        DateTime DatePublished { get; }
        int NumberOfPages { get; }
        string Genre { get; }
        string RecommendedBy { get; }
    }
}
