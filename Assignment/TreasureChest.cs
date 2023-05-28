namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        // Default Constructor
        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        // Constructor to instantiate with a variable state
        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        // Constructor to instantiate with parameters
        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        // This is called a getter
        public State GetState()
        {
            return _state;
        }

        public State Manipulate(Action action)
        {
            switch (action)
            {
                case Action.Open:
                    Open();
                    break;

                case Action.Close:
                    Close();
                    break;

                case Action.Lock:
                    Lock();
                    break;

                case Action.Unlock:
                    Unlock();
                    break;
            }
            return _state;
        }

        public void Unlock()
        {
            // Check the chest's current state and make decision
            if (_state == State.Closed)
            {
                Console.WriteLine("The chest is already unlocked!");
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open! Please close it to proceed.");
            }
            else if (_state == State.Locked)
            {
                _state = State.Closed;
            }
        }

        public void Lock()
        {
            // Check the chest's current state and make decision
            if (_state == State.Closed)
            {
                _state = State.Locked;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest cannot be locked because it is open.");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest is already locked!");
            }
        }

        public void Open()
        {
            // Check the chest's current state and make decision
            if (_state == State.Closed)
            {
                _state = State.Open;
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already open!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
        }

        public void Close()
        {
            // Check the chest's current state and make decision
            if (_state == State.Closed)
            {
                Console.WriteLine("The chest is already closed!");
            }
            else if (_state == State.Open)
            {
                _state = State.Closed;
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest is already closed and locked!");
            }
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }
}
