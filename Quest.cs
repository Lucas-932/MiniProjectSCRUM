public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public bool Completed = false;

    public Quest(int ID, string Name, string Description)
    {
        this.ID = ID;
        this.Name = Name;
        this.Description = Description;
    }
}