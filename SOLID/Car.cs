namespace SOLID;

public class Car
{
    public Car(string model, string brand,string problem)
    {
        
        this.model = model;
        this.brand = brand;
        Problem = problem;
    }

    private string brand { get; set; }
    private string model { get; set; }
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