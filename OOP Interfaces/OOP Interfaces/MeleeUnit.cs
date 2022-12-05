// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
abstract class MeleeUnit : Unit
{

   
    protected MeleeWeapons meleeWeapons;

    public MeleeWeapons MeleeWeapons {get => meleeWeapons; protected set => meleeWeapons = value; }





}
class MeleeWeapons
{
    protected Dice meleeDamage;

    protected int range;
    public Dice MeleeDamage { get => meleeDamage; protected set => meleeDamage = value; }
    public int Range { get => range; protected set => range = value; }
    
}

class LightSword : MeleeWeapons
{
    public LightSword()
    {
        meleeDamage = new Dice(2,4,3);   
        range = 12;
    }
}
class Axe : MeleeWeapons
{

    public Axe()
    {
        MeleeDamage = new Dice(1,4,5);
        Range = 2;
    }   
}

class HeavySword : MeleeWeapons
{
    public HeavySword()
    {
        meleeDamage = new Dice(9,4,3);
        range = 10;
    }
}

