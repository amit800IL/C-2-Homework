// ---- C# II (Dor Ben Dor) ----
//          Amit Kremer
// -----------------------------

struct Bag : IRandomProvider
{

    List<int> numbers = new List<int>();

    List<int> usedNumbers = new List<int>();

    Random random = new();

    int drawnNumber = 0;

    public Bag(List<int> numbersList)
    {
        foreach (int number in numbersList)
        {
            numbers.Add(number);
        }
    }

    public int RandomNumbers()
    {

        if (numbers.Count == 0)
        {
            for (int i = 0; i < usedNumbers.Count; i++)
            {
                numbers.Add(usedNumbers[i]);
            }

            usedNumbers.Clear();

        }
        return DrawnRandomNumber();

    }

    public int DrawnRandomNumber()
    {
        drawnNumber = numbers[random.Next(0, numbers.Count)];

        numbers.Remove(drawnNumber);

        usedNumbers.Add(drawnNumber);

        return drawnNumber;
    }
}

