using System;
namespace Planner
{
    /// <summary>
    /// Holds all data relating to the user, such as their budget.
    /// </summary>
    public class User
    {
        private float _budget;
        public float Budget
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