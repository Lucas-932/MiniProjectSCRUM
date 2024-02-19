public class Player
{
    public string Name;
    public Location CurrentLocation;
    public Weapon CurrentWeapon;
    public int MaximumHitPoints;
    public int CurrentHitPoints;

    public Player(string Name, Location CurrentLocation, Weapon CurrentWeapon, int MaximumHitPoints, int CurrentHitPoints)
    {
        this.Name = Name;
        this.CurrentLocation = CurrentLocation;
        this.CurrentWeapon = CurrentWeapon;
        this.MaximumHitPoints = MaximumHitPoints;
        this.CurrentHitPoints = CurrentHitPoints;
        
    }

    public bool Move(string direction) {
        switch (direction)
            {
                case "n":
                    if (CurrentLocation.LocationToNorth != null) {
                        CurrentLocation = CurrentLocation.LocationToNorth;
                    }
                    break;
                case "e":
                    if (CurrentLocation.LocationToEast != null) {
                        CurrentLocation = CurrentLocation.LocationToEast;
                    }
                    break;
                case "s":
                    if (CurrentLocation.LocationToSouth != null) {
                        CurrentLocation = CurrentLocation.LocationToSouth;
                    }
                    break;
                case "w":
                    if (CurrentLocation.LocationToWest != null) {
                        CurrentLocation = CurrentLocation.LocationToWest;
                    }
                    break;
                default:
                    return false;
            }
        return true;
    }

    public void DisplayStats() {
        Console.WriteLine($"You are at: \n{CurrentLocation.Name}\n{CurrentLocation.Description}");
        Console.WriteLine(
            CurrentLocation.MonsterLivingHere != null 
                ? $"You see a {CurrentLocation.MonsterLivingHere.Name}." 
                : "You see no monsters here."
        );
        Console.WriteLine($"You have {CurrentHitPoints} out of {MaximumHitPoints} HP left");
    }
}