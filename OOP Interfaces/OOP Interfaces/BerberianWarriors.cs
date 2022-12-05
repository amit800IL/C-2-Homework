// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
class BerberianWarriors : MeleeUnit
{
    Random random = new Random();
    public BerberianWarriors()
    {
        this.HpNum = 5;
        this.CarryingCapacity = 50;
        this.AttackDice = new Dice(2, 6, 3);
        this.HitChance = new Dice(2, 6, 2);
        this.DefenseRating = new Dice(2, 6, 3);
        this.EvasionChance = new Dice(3,6,4);
        this.ResourcesNum = random.Next(5,50);
        this.UnitRace = Race.Roman;
        this.meleeWeapons = new Axe();

    }

    public override void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {
        int DamageBonus = 5;

        if (attackingUnit is MongolMagicans)
        {
            TakeDamage(damageAmount + DamageBonus);
        }

        base.TryDefend(attackingUnit, damageAmount, hitChance, defendingChance, evading);

    }
}

