// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------

class Fighting
{
    Weather currentWeather;

    int romanstartingResources;
    int greektstartingResources;
    public int RomanstartingResources { get => romanstartingResources; protected set => romanstartingResources = value; }
    public int GreektstartingResources { get => greektstartingResources; protected set => greektstartingResources = value; }

    Army romanArmy = new Army();
    Army GreekArmy = new Army();

    private List<Unit> romanArmyUnits = new List<Unit>();
    public List<Unit> RomanArmyUnits { get => romanArmyUnits; protected set => romanArmyUnits = value; }

    Knight knight = new();
    RomanMagican romanMagican = new();
    BerberianWarriors berberianWarriors = new();

    private List<Unit> greekArmyUnits = new List<Unit>();
    public List<Unit> GreekArmyUnits { get => greekArmyUnits; protected set => greekArmyUnits = value; }

    GreekWarriors greek = new();
    SpanishWarriors SpanishWarriors = new();
    EgyptianMagicans EgyptianMagicans = new();


    public List<Unit> addRomanArmy()
    {
        List<Unit> romans = new List<Unit>()
        {
         knight,
         romanMagican,
         berberianWarriors,
        };

        foreach (Unit unit in romans)
        {
            RomanArmyUnits.Add(unit);
        }

        RomanResources();
        return RomanArmyUnits;

    }

    public int RomanResources()
    {
        romanArmy.ArmyList = RomanArmyUnits;

        RomanstartingResources = 0;

        for (int i = 0; i < romanArmy.ArmyList.Count; i++)
        {
            if (romanArmy.ArmyList[i].HpNum >= 0)
            {
                int ResourcesRoll = romanArmy.ArmyList[i].ResourcesNum;
                RomanstartingResources += ResourcesRoll;

            }
        }

        Console.WriteLine("Roman Starting Resources " + RomanstartingResources);
        return RomanstartingResources;

    }

    public int GreekResources()
    {
        GreekArmy.ArmyList = GreekArmyUnits;

        GreektstartingResources = 0;

        for (int i = 0; i < GreekArmy.ArmyList.Count; i++)
        {
            if (GreekArmy.ArmyList[i].HpNum >= 0)
            {
                int resourcesRoll = GreekArmy.ArmyList[i].ResourcesNum;
                GreektstartingResources += resourcesRoll;
            }
        }
        Console.WriteLine("Greek Starting Resources :" + GreektstartingResources);
        return GreektstartingResources;

    }

    public List<Unit> addGreekArmy()
    {
        List<Unit> Greeks = new List<Unit>()
        {
         greek,
         SpanishWarriors,
         EgyptianMagicans,
        };

        foreach (Unit unit in Greeks)
        {
            GreekArmyUnits.Add(unit);

        }
        GreekResources();
        return GreekArmyUnits;

    }
    public int RomanLoot()
    {
        romanArmy.ArmyList = RomanArmyUnits;
        for (int i = 0; i < romanArmy.ArmyList.Count; i++)
        {
            if (romanArmy.ArmyList[i].HpNum >= 0)
            {
                GreektstartingResources = romanArmy.ArmyList[i].CarryingCapacity;
            }
        }
        romanArmy.ArmyLoot += GreektstartingResources;
        GreekArmy.ArmyLoot -= GreektstartingResources;


        return romanArmy.ArmyLoot;





    }

    public int GreekLoot()
    {
        GreekArmy.ArmyList = GreekArmyUnits;
        for (int i = 1; i < GreekArmy.ArmyList.Count; i++)
        {
            if (GreekArmy.ArmyList[i].HpNum >= 0)
            {
                RomanstartingResources = GreekArmy.ArmyList[i].CarryingCapacity;
            }
        }
        GreekArmy.ArmyLoot += RomanstartingResources;
        romanArmy.ArmyLoot -= RomanstartingResources;

        return GreekArmy.ArmyLoot;



    }

    public void Battle(List<Unit> army1, List<Unit> army2)
    {

        bool flag = true;
        while (army1.Count > 0 && army2.Count > 0)
        {
            Unit unit1 = army1[Random.Shared.Next(0, army1.Count)];
            Unit unit2 = army2[Random.Shared.Next(0, army2.Count)];


            Random random = new Random();

            int result = random.Next(1, 100);
            if (result <= 60)
            {

                Array WeatherEnums = Enum.GetValues(typeof(Weather));
                random = new Random();
                currentWeather = (Weather)WeatherEnums.GetValue(random.Next(WeatherEnums.Length));

            }

            if (flag)
            {
                unit1.Attack(unit2);
                unit1.WeatherEffects(currentWeather);


                if (unit2.HpNum <= 0)
                {
                    GreekArmyUnits.Remove(unit2);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(unit2 + " from army unit 2 Are Dead ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                }
                flag = false;
            }
            else
            {
                unit2.Attack(unit1);
                unit2.WeatherEffects(currentWeather);



                if (unit1.HpNum <= 0)
                {
                    RomanArmyUnits.Remove(unit1);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(unit1 + " from armyUnit 1 Are Dead");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }

                flag = true;
            }
            if (RomanArmyUnits.Count <= 0)
            {
                Console.WriteLine(" Greek army won");
                Console.WriteLine(" Greek army Resources loot :" + GreekLoot());


            }
            else if (GreekArmyUnits.Count <= 0)
            {
                Console.WriteLine(" Roman Army Won ");
                Console.WriteLine(" Roman Resources loot :" + RomanLoot());
            }
        }




    }


}

