// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
class MongolMagicans : MagicUnit
{
    Random random = new Random();
    public MongolMagicans()
    {
        this.HpNum = 10;
        this.CarryingCapacity = 20;
        this.AttackDice = new Dice(2, 6, 3);
        this.HitChance = new Dice(1, 6, 8);
        this.DefenseRating = new Dice(2, 6, 3);
        this.EvasionChance = new Dice(3, 6, 4);
        this.ResourcesNum = random.Next(1,35);
        this.UnitRace = Race.Asian;
        this.magicType = new NatureMagic();
    }


    public override void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {
        int damageBonus = 5;
        int Damage = AttackDice.RandomNumbers();

        if (attackingUnit is Samurai)
        {
            attackingUnit.TakeDamage(Damage + damageBonus);
        }

        base.TryDefend(attackingUnit, damageAmount, hitChance, defendingChance, evading);
    }



}

