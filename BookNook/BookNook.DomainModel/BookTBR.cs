using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel
{
    public class BookTBR : Book
    {
        protected string recommendedBy;

        public BookTBR(string title, string author, string publisher, DateTime datePublished, int numPages, string genre, string recommendedBy)
        {
            _title = title;
            _author = author;
            _publisher = publisher;
            _datePublished = datePublished;
            _numPages = numPages;
            _genre = genre;
            this.recommendedBy = recommendedBy;
        }

        public string RecommendedBy
        {
            get { return recommendedBy; }
            set { recommendedBy = value; }
        }
    }
}
