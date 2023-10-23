namespace Dependency_Inversion;

public class RepairBox : IBox
{
    public void CheckProblem(string problem)
    {
        Console.WriteLine("Checking " + problem);
    }
    public void Repair(string problem)
    {
        Console.WriteLine(problem + " was repaired!");
    }
}