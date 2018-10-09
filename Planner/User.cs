using System;
namespace Planner
{
    /// <summary>
    /// Holds all data relating to the user, such as their budget.
    /// </summary>
    public class User
    {
        private decimal _budget;

        public decimal Budget
        {
            get;
            set;
        }

        public User()
        {
            throw new NotImplementedException();
        }

    }
}