public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public string sayingLine;
    public bool Completed = false;

    public Quest(int ID, string Name, string Description, string sayingLine)
    {
        this.ID = ID;
        this.Name = Name;
        this.Description = Description;
        this.sayingLine = sayingLine;
        Completed = false;
    }
    public void Complete()
    {
        Completed = true;
        Console.WriteLine($"Quest '{Name}' completed!");
        Program.CheckWinCondition(); // check win condition when a quest is completed
    }
}
