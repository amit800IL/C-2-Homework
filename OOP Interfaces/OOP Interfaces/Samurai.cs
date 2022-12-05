// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
class Samurai : MeleeUnit
{
    Random random = new Random();

    public Samurai()
    {
        this.HpNum = 15;
        this.CarryingCapacity = 30;
        this.AttackDice = new Dice(2, 6, 3);
        this.HitChance = new Dice(4, 6, 2);
        this.DefenseRating = new Dice(2, 6, 3);
        this.EvasionChance = new Dice(3, 6, 4);
        this.ResourcesNum = random.Next(1,30);
        this.UnitRace = Race.Asian;
        this.meleeWeapons = new LightSword();

    }


    public override void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {

        int hpGain = 10;

        if (attackingUnit is MongolMagicans)
        {
            this.ElevateHp(hpGain);
        }


        base.TryDefend(attackingUnit, damageAmount, hitChance, defendingChance, evading);
    }
   
}

