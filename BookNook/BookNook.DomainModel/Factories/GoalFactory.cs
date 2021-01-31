using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel.Factories
{
    class GoalFactory
    {
        public static Goal CreateGoal(string description, DateTime startDate, DateTime endDate)
        {
            return new Goal(description, startDate, endDate);
        }

        public static GoalBook CreateBookGoal(string description, DateTime startDate, DateTime endDate, BookTBR bookToRead)
        {
            return new GoalBook(description, startDate, endDate, bookToRead);
        }
    }
}
