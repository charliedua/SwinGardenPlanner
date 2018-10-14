using System;

namespace Planner
{
    /// <summary>
    /// Holds all data relating to the user, such as their budget.
    /// </summary>
    public class User
    {
        private decimal _budget;

        public User()
        {
            throw new NotImplementedException();
        }

        public decimal Budget { get => _budget; set => _budget = value; }
    }
}