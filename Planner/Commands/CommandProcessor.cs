using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    internal class CommandProcessor
    {
        private List<Command> _commands;

        public List<Command> Commands { get => _commands; set => _commands = value; }

        public static string[] SplitString(string text)
        {
            return text.Split(' ');
        }

        public string Execute(string Text)
        {
            return null;
        }
    }
}