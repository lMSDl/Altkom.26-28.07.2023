using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Command
{
    internal interface ICommand
    {
        bool Execute();
        void Reverse();
    }
}
