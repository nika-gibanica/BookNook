using System;

namespace BookNook.DomainModel
{
    public class Goal
    {
        public int _goalId;
        protected string _description;
        protected DateTime _startDate;
        protected DateTime _endDate;
        protected bool _completed;

        public Goal(string description, DateTime startDate, DateTime endDate)
        {
            _description = description;
            _startDate = startDate;
            _endDate = endDate;
            _completed = false;
        }

        public int GoalId
        {
            get { return _goalId; }
            set { _goalId = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public void completeGoal()
        {
            _completed = true;
        }
    }
}
