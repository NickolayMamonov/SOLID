namespace DependencyInversion;

public class Car
{
    public Car(string model, string brand,string problem)
    {
        Model = model;
        Brand = brand;
        Problem = problem;
        Box = new PaintingBox();
    }

    private string Brand { get; set; }
    private string Model { get; set; }
    private string Problem { get; set; }
    private PaintingBox Box { get; set; }

    public void CheckProblem()
    {
        Box.CheckProblem(Problem);
    }
    public void Repair()
    {
        Box.Repair(Problem);
    }
}