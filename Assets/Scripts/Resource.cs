public class Resource
{
    public int amount;
    public string identifier;
    public string unit;

    public Resource(string identifier, int amount, string unit)
    {
        this.identifier = identifier;
        this.amount = amount;
        this.unit = unit;
    }
}