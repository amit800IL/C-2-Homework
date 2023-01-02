class ObservableLimitedList
{
    private List<string> stringList = new List<string>();

    public event Func<string, string> listChanged;

    private CheckStringValidity predicate;



    public ObservableLimitedList(CheckStringValidity validity)
    {
        predicate = validity;


        listChanged += PrintChangedItem;

    }
    public void TryAdd(string inputString)
    {
        if (predicate != null && predicate.Invoke(inputString))
        {
            stringList.Add(inputString);
            listChanged?.Invoke(inputString);

        }


    }

    public void Remove(string inputString)
    {
        stringList.Remove(inputString);
        listChanged?.Invoke(inputString);
    }

    public void PrintAll()
    {
        Console.WriteLine("This are the items that were added to the list: ");
        foreach (string inputString in stringList)
        {
            Console.WriteLine(inputString);
        }
    }
    public string PrintChangedItem(string inputString)
    {

        Console.WriteLine(inputString);

        return inputString;

    }


}

