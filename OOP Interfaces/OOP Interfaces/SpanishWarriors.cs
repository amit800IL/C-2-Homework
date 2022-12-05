// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
class SpanishWarriors : MeleeUnit
{
    Random random = new Random();   
    public SpanishWarriors()
    {
        this.HpNum = 30;
        this.CarryingCapacity = 100;
        this.AttackDice = new Bag(new List<int> {2,6,4});
        this.HitChance = new Dice(2, 6, 3);
        this.DefenseRating = new Dice(2, 6, 5);
        this.EvasionChance = new Dice(3, 6, 4);
        this.ResourcesNum = random.Next(1,50);
        this.UnitRace = Race.Greek;
        this.meleeWeapons = new HeavySword();

    }



    public override void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {
        int Damage = AttackDice.RandomNumbers();

        if (attackingUnit is RomanMagican)
        {
            Damage += 20;
            attackingUnit.TakeDamage(Damage);
        }


        base.TryDefend(attackingUnit, damageAmount, hitChance, defendingChance, evading);
    }


}

