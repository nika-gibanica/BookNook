using System;
using System.Collections.Generic;
using System.Text;
using BookNook.DomainModel;
using BookNook.DomainModel.Repositories;
using BookNook.Base;

namespace BookNook.MemoryBasedDAL
{
    public class GoalRepository : Subject, IGoalRepository
    {
        private List<Goal> _listGoals = new List<Goal>();
        private int _lastId = -1;
        private static GoalRepository _instance;

        public static GoalRepository getInstance()
        {
            return _instance ?? (_instance = new GoalRepository());
        }
        public List<Goal> getListGoals()
        {
            return _listGoals;
        }

        public int getLastId()
        {
            return _lastId;
        }

        public void AddGoal(Goal goal)
        {
            goal._goalId = ++_lastId;

            _listGoals.Add(goal);

            NotifyObservers();
        }

        public void AddBookGoal(GoalBook goal)
        {
            goal._goalId = ++_lastId;

            _listGoals.Add(goal);

            NotifyObservers();
        }

        public void RemoveGoal(int goalId)
        {
            for (int i = 0; i < _listGoals.Count; i++)
            {
                if (_listGoals[i]._goalId == goalId)
                {
                    _listGoals.RemoveAt(i);
                }
            }

            NotifyObservers();
        }

        public int getGoalNum()
        {
            return _listGoals.Count;
        }
    }
}
