public class Program
{
    public static Player player = new("bob", World.LocationByID(1), World.WeaponByID(1), 5, 5);
    public static bool running;
    public static void Main()
    {
        running = true;

        while (running)
        {
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
                    Fight();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Thanks for playing!");
                    break;
                    
            }

            CheckWinCondition();
        }
    }

    public static void CheckWinCondition()
    {
        bool questsUncleared = false;
        foreach (Quest quest in World.Quests)
        {
            if (!quest.Completed)
            {
                questsUncleared = true;
            }
        }

        if (!questsUncleared)
        {
            running = false;
            Console.WriteLine("You have won the game!");
        }
    }

    // Move functionality
    public static void Move()
    {
        bool moved;
        do
        {
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine($"You are at: {player.CurrentLocation.Name}. From here you can go:");
            DisplayCompass();
            string UserAction = (Console.ReadLine() ?? "").ToLower();
            moved = player.Move(UserAction);
        } while (!moved);
    }

    public static void DisplayCompass()
    {
        if (player.CurrentLocation.LocationToNorth != null)
        {
            Console.WriteLine($"(N)orth: {player.CurrentLocation.LocationToNorth.Name}");
        }
        if (player.CurrentLocation.LocationToWest != null)
        {
            Console.WriteLine($"(W)est: {player.CurrentLocation.LocationToWest.Name}");
        }
        if (player.CurrentLocation.LocationToEast != null)
        {
            Console.WriteLine($"(E)ast: {player.CurrentLocation.LocationToEast.Name}");
        }
        if (player.CurrentLocation.LocationToSouth != null)
        {
            Console.WriteLine($"(S)outh: {player.CurrentLocation.LocationToSouth.Name}");
        }
    }


    // Display all current stats
    public static void DisplayStats()
    {
        player.DisplayStats();
        Console.WriteLine("Quest Lines:");
        Quest currentLocationQuest = player.CurrentLocation.QuestAvailableHere;
        if (currentLocationQuest != null && !currentLocationQuest.Completed)
        {
            Console.WriteLine(currentLocationQuest.sayingLine);
        }

        World.PopulateQuests();

        Console.WriteLine("\nPress ENTER to continue");
        Console.ReadLine();
    }

    // Checks if there is a fight and sets up the fight
    public static void Fight()
    {
        Monster CurrentMonster = player.CurrentLocation.MonsterLivingHere;
        if (CurrentMonster == null)
        {
            Console.WriteLine("There are no Monsters to fight here.");
        }
        else if (CurrentMonster.CurrentHitPoints <= 0)
        {
            Console.WriteLine("You have already slain all the Monsters.");
        }
        else
        {
            SuperAdventure FightingEncounter = new(CurrentMonster, player);
            bool result = FightingEncounter.StartFight();
            if (result)
            {
                Console.WriteLine($"You defeated the {CurrentMonster.Name}");
            }
            else
            {
                Console.WriteLine("You have died!");
                running = false;
            }
        }
    }
}