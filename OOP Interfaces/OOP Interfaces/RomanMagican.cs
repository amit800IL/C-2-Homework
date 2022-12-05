
// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------

class RomanMagican : MagicUnit
{
    Random random = new Random();
    public RomanMagican()
    {
        this.HpNum = 15;
        this.CarryingCapacity = 40;
        this.AttackDice = new Dice(2, 6, 3);
        this.HitChance = new Dice(4, 6, 2);
        this.DefenseRating = new Dice(2, 6, 3);
        this.EvasionChance = new Dice(3, 6, 4);
        this.ResourcesNum = random.Next(3,40);
        this.UnitRace = Race.Roman;
        this.magicType = new BlackMagic();
    }

    public override void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {
        int DamageNum = damageAmount;
        int DamagePenalty = HitChance.RandomNumbers();

        if (DamagePenalty < DamageNum)
        {
            DamageNum += 5;
        }

        attackingUnit.TakeDamage(DamageNum);

        base.TryDefend(attackingUnit, damageAmount, hitChance, defendingChance, evading);
    }


}

