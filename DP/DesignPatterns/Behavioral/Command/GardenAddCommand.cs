using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Command
{
    internal class GardenAddCommand : ICommand
    {
        private readonly Garden _garden;
        private readonly string _plantName;

        public GardenAddCommand(Garden garden, string plantName)
        {
            _garden = garden;
            _plantName = plantName;
        }

        public bool Execute()
        {
            return _garden.Add(_plantName);
        }

        public void Reverse()
        {
            _garden.Remove(_plantName);
        }
    }
}
