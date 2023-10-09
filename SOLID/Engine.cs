namespace SOLID;

public class Engine : Car
{
    public Engine(string model, string brand, string problem)
    {
        Model = model;
        Brand = brand;
        Problem = problem;
    }
    
    public override void Repair()
    {
        //Реализация
        Console.WriteLine("Двигатель отремонтирован!");
    }
}