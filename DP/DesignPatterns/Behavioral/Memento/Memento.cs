using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Memento
{
    internal class Memento<T> where T : ICloneable
    {
        private readonly T _state;
        public DateTime DateTime { get; }

        public Memento(T originator)
        {
            _state = (T)originator.Clone();
            DateTime = DateTime.Now;
        }

        public T GetState()
        {
            return (T)_state.Clone();
        }
    }
}
