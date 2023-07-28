using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Command
{
    internal class GardenRemoveCommand : ICommand
    {
        private readonly Garden _garden;
        private readonly string _plantName;

        public GardenRemoveCommand(Garden garden, string plantName)
        {
            _garden = garden;
            _plantName = plantName;
        }

        public bool Execute()
        {
            return _garden.Remove(_plantName);
        }

        public void Reverse()
        {
            _garden.Add(_plantName);
        }
    }
}
