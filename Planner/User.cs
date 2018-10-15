using System;

namespace Planner
{
    /// <summary>
    /// Holds all data relating to the user, such as their budget.
    /// </summary>
    public class User : GardenObject
    {
        private decimal _budget;

        public User(int id, string name) : base(id, name)
        {
        }

        public decimal Budget { get => _budget; set => _budget = value; }
    }
}