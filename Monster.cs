public class Monster
{
    public int ID;
    public int MaximumDamage;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public string Name;
    
    public Monster(int ID, string Name, int MaximumDamage, int CurrentHitPoints, int MaximumHitPoints)
    {
        
        this.ID = ID;
        this.Name = Name;
        this.MaximumDamage = MaximumDamage;
        this.CurrentHitPoints = CurrentHitPoints;
        this.MaximumHitPoints = MaximumHitPoints;
    }
}