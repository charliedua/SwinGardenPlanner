using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Commands
{
    public class CommandProcessor
    {
        private List<Command> _commands;

        public CommandProcessor()
        {
            _commands = new List<Command>()
            {
                new AddGardenCommand(),
                new ShowGardenCommand(),
                new AddPlantCommand(),
                new SetBudgetCommand()
            };
        }

        public List<Command> Commands { get => _commands; set => _commands = value; }

        public static string[] SplitString(string text)
        {
            return text.Split(' ');
        }

        public string Execute(PlannerController controller, string Text)
        {
            string[] textarr = SplitString(Text);
            Command command = null;
            foreach (var item in _commands)
            {
                if (item.AreYou(textarr[0]))
                {
                    command = item;
                }
            }
            if (command != null)
            {
                return command.Execute(controller, textarr);
            }
            else
            {
                return "This is not possible";
            }
        }
    }
}