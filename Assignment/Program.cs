namespace Assignment
{
    static class Program
    {
        static void Main()
        {
            // Basic Testing
            System.Console.WriteLine("Testing TreasureChest.cs ...");
            TreasureChest chest = new(TreasureChest.State.Closed);

            TreasureChest.State state1 = chest.Manipulate(TreasureChest.Action.Open);
            Console.WriteLine("Current state is: " + state1);

            TreasureChest.State state2 = chest.Manipulate(TreasureChest.Action.Lock);
            Console.WriteLine("Current state is: " + state2);

            TreasureChest.State state3 = chest.Manipulate(TreasureChest.Action.Close);
            Console.WriteLine("Current state is: " + state3);

            TreasureChest.State state4 = chest.Manipulate(TreasureChest.Action.Lock);
            Console.WriteLine("Current state is: " + state4);
        }
    }
}
