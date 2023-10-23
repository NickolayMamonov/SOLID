namespace Dependency_Inversion;

public class PaintingBox : IBox
{
    public void CheckProblem(string problem)
    {
        Console.WriteLine("Checking " + problem);
    }
    public void Repair(string problem)
    {
        Console.WriteLine(problem + " was painted!");
    }
}