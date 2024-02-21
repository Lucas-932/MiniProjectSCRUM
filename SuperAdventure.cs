public class SuperAdventure
{
    public Monster CurrentMonster;
    public Player ThePlayer;

    public SuperAdventure(Monster CurrentMonster, Player ThePlayer)
    {
        this.CurrentMonster = CurrentMonster;
        this.ThePlayer = ThePlayer;
    }

    public bool StartFight() {
        // while monster and player are both alive
        while (CurrentMonster.CurrentHitPoints > 0 && ThePlayer.CurrentHitPoints > 0)
        {
            // get their damage value
            int MonsterHit = World.RandomGenerator.Next(CurrentMonster.MaximumDamage + 1);
            int PlayerHit = World.RandomGenerator.Next(ThePlayer.CurrentWeapon.MaximumDamage + 1);

            // if player damage is more than zero do damage
            if (PlayerHit == 0) {
                Console.WriteLine($"You missed the {CurrentMonster.Name}");
            } else {
                Console.WriteLine($"You did {PlayerHit} points of damage!");
                CurrentMonster.CurrentHitPoints -= PlayerHit;
            }
            // display monster health
            Console.WriteLine($"The {CurrentMonster.Name} has {CurrentMonster.CurrentHitPoints} out of {CurrentMonster.MaximumHitPoints} HP left");

            if (CurrentMonster.CurrentHitPoints > 0) {
                Console.WriteLine();
                // if monster damage is more than zero do damage
                if (MonsterHit == 0) {
                    Console.WriteLine($"The {CurrentMonster.Name} missed you");
                } else {
                    Console.WriteLine($"The {CurrentMonster.Name} did {MonsterHit} points of damage!");
                    ThePlayer.CurrentHitPoints -= MonsterHit;
                }
                Console.WriteLine($"You have {ThePlayer.CurrentHitPoints} out of {ThePlayer.MaximumHitPoints} HP left");
            }

            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }

        // return true if the monster is the one who died
        return CurrentMonster.CurrentHitPoints <= 0;
    }
}