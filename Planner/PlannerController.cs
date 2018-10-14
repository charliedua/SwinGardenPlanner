using System;

namespace Planner
{
    /// <summary>
    /// The main controller for the Garden Planner program.
    /// </summary>
    public class PlannerController
    {
        public User CurrentUser;
        private Commands.CommandProcessor _processor;

        public PlannerController()
        {
            throw new NotImplementedException();
        }

        public Plant[] Plants { get; }
    }
}