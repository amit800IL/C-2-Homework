// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
class ChineseMagicans : MagicUnit
{
    Random random = new Random();
    public ChineseMagicans()
    {
        this.HpNum = 10;
        this.CarryingCapacity = 30;
        this.AttackDice = new Dice(2, 6, 3);
        this.HitChance = new Dice(2, 6, 2);
        this.DefenseRating = new Dice(2, 6, 3);
        this.EvasionChance = new Dice(1, 6, 3);
        this.ResourcesNum = random.Next(6,60);
        this.UnitRace = Race.Asian;
        this.magicType = new BlackMagic();
  
    }


    public override void TryDefend(Unit AttackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {
        int hp = 20;
        if (AttackingUnit is Samurai)
        {
            AttackingUnit.ElevateHp(hp);
        }

        base.TryDefend(AttackingUnit, damageAmount , hitChance ,defendingChance, evading);
    }

   
}

