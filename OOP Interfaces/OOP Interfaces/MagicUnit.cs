// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
abstract class MagicUnit : Unit
{
    

    protected MagicType magicType;

    

}
class MagicType
{
    protected Dice magicDamage;

    protected int magicEffectRange;
    public virtual Dice MagicDamage { get => magicDamage; protected set => magicDamage = value; }
    public virtual int MagicEffectRange { get => magicEffectRange; protected set => magicEffectRange = value; }
}

class BlackMagic : MagicType
{
   public BlackMagic()
    {
        magicDamage = new Dice(4,4,2);
        magicEffectRange = 30;
    }
}

class NatureMagic : MagicType
{
   public NatureMagic()
    {
        magicDamage = new Dice(2,4,9);
        magicEffectRange = 15;

    }
}











