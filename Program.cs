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
                    DisplayStats();
                    break;
                case "2":
                    Move();
                    break;
                case "3":
                    // Fight();
                    break;
                case "4":
                    // quit
                    break;
            }
        }
    }
    
    // Move functionality
    public static  void Move() {
        bool moved;
        do
        {   
            // Prints UI
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine($"You are at: {player.CurrentLocation.Name}. From here you can go:");
            DisplayCompass();
            string UserAction  = (Console.ReadLine() ?? "").ToLower();

            // Checks for which direction and if possible, set current location to the correct location
            moved = player.Move(UserAction);
        } while (!moved);
    }

    public static void DisplayCompass() {
        // Possible direction compass here
        Console.WriteLine("Direction Compass not yet implemented. From Home you can go (N)orth");
    }

    // Display all current stats
    public static void DisplayStats() {
        player.DisplayStats();

        Console.WriteLine("\nPress ENTER to continue");
        Console.ReadLine();
    }
}