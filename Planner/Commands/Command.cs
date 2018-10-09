using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    internal abstract class Command
    {
        /// <summary>
        /// Gets or sets the identifiers.
        /// </summary>
        /// <value>
        /// The identifiers.
        /// </value>
        public abstract string[] Identifiers { get; set; }

        /// <summary>
        /// Executes the specified command text.
        /// </summary>
        /// <param name="CommandText">The command text.</param>
        public abstract string Execute(string CommandText);
    }
}