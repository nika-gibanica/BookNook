using System;
using System.Collections.Generic;
using System.Text;

namespace BookNook.DomainModel.Repositories
{
    public interface IGoalRepository
    {
        List<Goal> getListGoals();
        int getLastId();
        void AddGoal(Goal goal);
        void AddBookGoal(GoalBook goal);
        void RemoveGoal(int goalId);
        int getGoalNum();
    }
}
