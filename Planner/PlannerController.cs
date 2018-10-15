using Planner.Commands;
using System;
using System.Collections.Generic;

namespace Planner
{
    /// <summary>
    /// The main controller for the Garden Planner program.
    /// </summary>
    public class PlannerController
    {
        private Garden _garden = null;
        public User CurrentUser;
        private CommandProcessor _processor;

        public List<Plant> Plants { get; set; }

        public PlannerController(string username)
        {
            _processor = new CommandProcessor();
            CurrentUser = new User(0, username);
        }

        public Garden Garden { get => _garden; set => _garden = value; }
    }
}