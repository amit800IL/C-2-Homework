// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
public struct Dice : IRandomProvider
{
    private uint _numberOfDice;
    private uint _diceType;
    private int _modifier;

    public uint NumberOfDice { get => _numberOfDice; }
    public uint DiceType { get => _diceType; }
    public int Modifier { get => _modifier; }

    public Dice(uint numberOfDice, uint diceType, int modifier)
    {
        this._numberOfDice = numberOfDice;
        this._diceType = diceType;
        this._modifier = modifier;
    }



    public int Roll()
    {
        Random random = new Random();

        return random.Next((int)NumberOfDice * (int)DiceType) + Modifier;
    }

    public override string ToString()
    {
        string opoerator;
        if (Modifier > 0)
        {
            opoerator = "+";
        }
        else
        {
            opoerator = "-";
        }
        return NumberOfDice + "d" + DiceType + opoerator + Modifier;
    }

    public override bool Equals(object obj)
    {
        if (!(obj is Dice))
        {
            return false;
        }
        else
        {

            Dice dice = (Dice)obj;

            if (dice.GetHashCode() == GetHashCode())
            {
                return true;
            }

            return false;

        }




    }

    public override int GetHashCode()
    {
        return (((int)this.NumberOfDice + this.Modifier) * (int)this.DiceType + this.Modifier);
    }

    public int RandomNumbers() => Roll();
    
}


