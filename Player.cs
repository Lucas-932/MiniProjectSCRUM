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
}