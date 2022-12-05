// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------

class EgyptianMagicans : MagicUnit
{
    Random random = new Random();
    public EgyptianMagicans()
    {
        this.HpNum = 25;
        this.CarryingCapacity = 45;
        this.AttackDice = new Dice(2, 6, 3);
        this.HitChance = new Dice(2, 6, 2);
        this.DefenseRating = new Dice(2, 6, 5);
        this.EvasionChance = new Dice(3, 6, 4);
        this.ResourcesNum = random.Next(4,70);
        this.UnitRace = Race.Greek;
        this.magicType = new BlackMagic();
    }
    

    public override void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {

        int damageBonus = HpNum / 5;

        base.TryDefend(attackingUnit, damageAmount + damageBonus, hitChance, defendingChance, evading);
    }
}

