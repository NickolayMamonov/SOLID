namespace Dependency_Inversion;

public class Car
{
    public Car(string model, string brand,string problem, IBox box)
    {
        Model = model;
        Brand = brand;
        Problem = problem;
        Box = box;
    }

    private string Brand { get; set; }
    private string Model { get; set; }
    private string Problem { get; set; }
    private IBox Box { get; set; }

    public void CheckProblem()
    {
        Box.CheckProblem(Problem);
    }
    public void Repair()
    {
        Box.Repair(Problem);
    }
}