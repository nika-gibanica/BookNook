using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel
{
    public class GoalBook : Goal
    {
        private BookTBR bookToRead;

        public GoalBook(string description, DateTime startDate, DateTime endDate, BookTBR bookToRead) : base(description, startDate, endDate)
        {
            this.bookToRead = bookToRead;
        }

        public BookTBR BookToRead
        {
            get { return bookToRead; }
            set { bookToRead = value; }
        }

    }
}
