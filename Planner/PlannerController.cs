using System;

namespace Planner
{
    /// <summary>
    /// The main controller for the Garden Planner program.
    /// </summary>
    public class PlannerController
    {
        private Commands.CommandProcessor _processor;

        public Plant[] Plants { get; }

        public PlannerController()
        {
            throw new NotImplementedException();
        }

        public User CurrentUser;
    }
}