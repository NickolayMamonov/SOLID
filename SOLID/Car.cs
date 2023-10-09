namespace SOLID;

public abstract class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Problem { get; set; }
    public abstract void Repair();
}