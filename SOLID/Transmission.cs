namespace SOLID;

public class Transmission: Car
{
    public Transmission(string model, string brand, string problem)
    {
        Model = model;
        Brand = brand;
        Problem = problem;
    }

  

    public override void Repair()
    {
        //Реализация
        Console.WriteLine("Трансмиссия отремонтирована!");
    }
}