// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------
struct Army
{
    private List<Unit> _armyList;

    private int _armyLoot;
    public int ArmyLoot { get => _armyLoot; set => _armyLoot = value; }
    public List<Unit> ArmyList { get => _armyList; set => _armyList = value; }

    public Army(int _armyLoot)
    {
       
        _armyList = new List<Unit>();
        this._armyLoot = _armyLoot;
    }

    
}

