// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------

class GreekWarriors : MeleeUnit
{
    Random random = new Random();
    public GreekWarriors()
    {
        this.HpNum = 10;
        this.CarryingCapacity = 10;
        this.AttackDice = new Dice(2, 6, 3);
        this.HitChance = new Dice(4, 6, 2);
        this.DefenseRating = new Dice(2, 6, 3);
        this.EvasionChance = new Dice(3, 6, 4);
        this.ResourcesNum = random.Next(3,80);
        this.UnitRace = Race.Greek;
        this.meleeWeapons = new HeavySword();

    }


    public override void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {
        int damageBonus = 5;
        if (attackingUnit is RomanMagican)
        {
            TakeDamage(damageAmount + damageBonus);
        }
        else
        {
            Console.WriteLine("Attacking Unit Missed");
            Console.WriteLine();
        }


        base.TryDefend(attackingUnit, damageAmount, hitChance, defendingChance, evading);
    }
}



