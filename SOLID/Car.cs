namespace SOLID;

public class Car
{
    public Car(string model, string brand,string problem)
    {
        Model = model;
        Brand = brand;
        Problem = problem;
    }

    private string Brand { get; set; }
    private string Model { get; set; }
    private string Problem { get; set; }

    public void Repair()
    {
        if (Problem == "Engine")
        {
            Console.WriteLine("Двигатель отремонтирован!");
        }
        else if (Problem == "Transmission")
        {
            Console.WriteLine("Трансмиссия отремонтирована!");
        }
    }
}