namespace DependencyInversion;

public class PaintingBox
{
    
    public void CheckProblem(string problem)
    {
        Console.WriteLine("Checking " + problem);
    }
    public void Repair(string problem)
    {
        Console.WriteLine(problem + "was repaired!");
    }
}