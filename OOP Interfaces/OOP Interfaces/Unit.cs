// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
abstract class Unit
{

    private Race _unitRace;

    private Weather _weatherEffect;

    private int _caryyingCapacity;

    private int _hpNum;

    private int _resourcesNum;

    private IRandomProvider _evasionChance;

    private IRandomProvider _hitChance;

    private IRandomProvider _defenseRating;

    private IRandomProvider _attackDice;

    public int HpNum { get => _hpNum; protected set => _hpNum = value; }
    public Race UnitRace { get => _unitRace; protected set => _unitRace = value; }
    public int CarryingCapacity { get => _caryyingCapacity; protected set => _caryyingCapacity = value; }
    protected IRandomProvider HitChance { get => _hitChance; set => _hitChance = value; }
    protected IRandomProvider DefenseRating { get => _defenseRating;  set => _defenseRating = value; }
    protected IRandomProvider AttackDice { get => _attackDice;  set => _attackDice = value; }
    public Weather WeatherEffect { get => _weatherEffect;  set => _weatherEffect = value; }
    protected IRandomProvider EvasionChance { get => _evasionChance;  set => _evasionChance = value; }
    public int ResourcesNum { get => _resourcesNum; set => _resourcesNum = value; }

    virtual public void TakeDamage(int Damage)
    {

        HpNum -= Damage;
    }

    virtual public void ElevateHp(int hpNum)
    {
        HpNum += hpNum;
    }

    public void Attack(Unit DefendingUnit)
    {
        int hitChance = HitChance.RandomNumbers();
        int defedingChance = DefendingUnit.DefenseRating.RandomNumbers();
        int evading = DefendingUnit.EvasionChance.RandomNumbers();
        int damageAmount = _attackDice.RandomNumbers();

       DefendingUnit.TryDefend(this, damageAmount, hitChance, defedingChance, evading);

    }

     public virtual void TryDefend(Unit attackingUnit, int damageAmount, int hitChance, int defendingChance, int evading)
    {
        if (hitChance > defendingChance)
        {
            if (evading > hitChance)
            {
                Console.WriteLine();
                Console.WriteLine("Attack Evaded by :" + this);
                Console.WriteLine();
            }
            else
            {
               TakeDamage(damageAmount);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(this + "unit has been attacked by " + attackingUnit);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Attacking Unit Missed");
            Console.ForegroundColor = ConsoleColor.White;
  
        }
       
    }



    virtual public void WeatherEffects(Weather weather)
    {

        if (weather == Weather.BurnningHot)
        {
            this._hitChance = new Dice(5, 4, 3);

        }
        else if (weather == Weather.Stormy)
        {
            this.AttackDice = new Dice(3, 2, 1);
        }
        else if (weather == Weather.HardWinter)
        {
            this._caryyingCapacity -= 5;
        }
        Console.WriteLine();
        Console.WriteLine(" The Weather now is : " + weather);
        Console.WriteLine();

    }

}

public enum Race
{
    Roman,
    Greek,
    Asian
}

public enum Weather
{
    Stormy,
    BurnningHot,
    HardWinter
}

