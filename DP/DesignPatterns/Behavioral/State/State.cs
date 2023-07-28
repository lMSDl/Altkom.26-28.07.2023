using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.State
{
    internal abstract class State
    {
        protected CoffeeMachine CoffeeMachine { get; }
        protected State(CoffeeMachine coffeeMachine)
        {
            CoffeeMachine = coffeeMachine;
        }


        public abstract void Large();
        public abstract void Small();
    }
}
