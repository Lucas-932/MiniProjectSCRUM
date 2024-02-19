public class Program
{
    public static Player player = new("bob", World.LocationByID(1), World.WeaponByID(1), 5, 5);
    public static void Main()
    {
        bool running = true;

        while (running) {
            Console.WriteLine("What would you like to do (Enter a number)?");
            Console.WriteLine("1: See game stats");
            Console.WriteLine("2: Move");
            Console.WriteLine("3: Fight");
            Console.WriteLine("4: Quit");

            string UserAction = Console.ReadLine() ?? "";

            switch (UserAction)
            {
                case "1":
                    // stats
                    break;
                case "2":
                    // move
                    break;
                case "3":
                    // Fight
                    break;
                case "4":
                    // quit
                    break;
            }
        }
    }
}