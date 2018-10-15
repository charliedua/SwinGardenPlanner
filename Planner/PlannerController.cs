using System;
using System.Collections.Generic;

namespace Planner
{
    /// <summary>
    /// The main controller for the Garden Planner program.
    /// </summary>
    public class PlannerController
    {
        private Garden _garden;
        public User CurrentUser;
        private Commands.CommandProcessor _processor;

        public PlannerController()
        {
            throw new NotImplementedException();
        }

        public Garden Garden { get => _garden; set => _garden = value; }
    }
}