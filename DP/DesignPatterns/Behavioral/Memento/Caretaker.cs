using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Behavioral.Memento
{
    internal class Caretaker<T> where T : ICloneable, IRestorable<T>
    {
        private ICollection<Memento<T>> _mementos = new List<Memento<T>>();
        protected T _originator;

        public Caretaker(T originator)
        {
            _originator = originator;
            SaveState();
        }

        public void SaveState()
        {
            var memento = new Memento<T>(_originator);
            _mementos.Add(memento);
            Console.WriteLine($"Caretaker: snapshot {memento.DateTime}");
        }

        public void RestoreState()
        {
            var memento = _mementos.LastOrDefault();
            if (memento != null)
            {
                _mementos.Remove(memento);
                RestoreState(memento);
            }
        }

        public void RestoreState(DateTime dateTime)
        {
            var memento = _mementos.LastOrDefault(x => x.DateTime <= dateTime);
            if (memento != null)
            {
                RestoreState(memento);
            }
        }

        private void RestoreState(Memento<T> memento)
        {
            (memento.GetState() as Person).FirstName = "ala ma kota";


            _originator.Restore(memento.GetState());
            Console.WriteLine($"Caretaker: restored {memento.DateTime}");
        }
    }
}
