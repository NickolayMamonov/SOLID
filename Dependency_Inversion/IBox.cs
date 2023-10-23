namespace Dependency_Inversion;

public interface IBox
{
    void CheckProblem(string problem);
    void Repair(string problem);
}