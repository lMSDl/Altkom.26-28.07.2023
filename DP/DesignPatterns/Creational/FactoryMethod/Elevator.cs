using System.Windows.Input;

namespace DP.DesignPatterns.Creational.FactoryMethod
{
    internal class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public Elevator()
        {
            /*var type = typeof(IElevatorOperation);
            _operations = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => !x.IsInterface)
                .Where(x => type.IsAssignableFrom(x))
                .Select(x => (IElevatorOperation)Activator.CreateInstance(x))
                .ToDictionary(x => x.GetType().Name.Substring(nameof(Elevator).Length));*/

        }

            public void Execute(string action, int floor)
        {
            CreateOperation(action)?.Operate(floor);
        }
        /*public void Execute(IElevatorOperation operation, int floor)
            {
                operation?.Operate(floor);
            }*/

        public virtual IElevatorOperation CreateOperation(string action)
        {
            IElevatorOperation elevatorOperation = null;
            if (_operations.TryGetValue(action, out elevatorOperation))
            {
                return elevatorOperation;
            }

            switch (nameof(Elevator) + action)
            {
                case nameof(ElevatorDown):
                    elevatorOperation = new ElevatorDown();
                    break;
                case nameof(ElevatorUp):
                    elevatorOperation = new ElevatorUp();
                    break;
                case nameof(ElevatorGoTo):
                    elevatorOperation = new ElevatorGoTo();
                    break;
            }
            _operations[action] = elevatorOperation;

            return elevatorOperation;
        }
    }
}