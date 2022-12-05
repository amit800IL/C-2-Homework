// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
class Knight : MeleeUnit
{
    Random random = new Random();
    public Knight()
    {
        this.HpNum = 10;
        this.CarryingCapacity = 35;
        this.AttackDice = new Dice(2, 6, 3);
        this.HitChance = new Dice(2, 6, 2);
        this.DefenseRating = new Dice(2, 6, 2);
        this.EvasionChance = new Dice(3, 6, 4);
        this.ResourcesNum = random.Next(5,70);
        this.UnitRace = Race.Roman;
        this.meleeWeapons = new HeavySword();
    }


    public override void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {
        int maxHp = 10;
        int DamageBouns = maxHp / HpNum;

        if (hitChance > defendingChance)
        {
          TakeDamage(damageAmount + DamageBouns);
        }
        else
        {
            Console.WriteLine("Attacking Unit Missed");
            Console.WriteLine();
        }

        base.TryDefend(attackingUnit, damageAmount, hitChance, defendingChance, evading);
    }
}

