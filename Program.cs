public class Program
{
    public static void Main()
    {
        Console.WriteLine("test");
        Player player = new("bob", null, null, 5, 5);
        Console.WriteLine(player.MaximumHitPoints);
    }
}