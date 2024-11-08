using TemplateMethod.Models;

namespace TemplateMethod.Services;

public abstract class EmployeeEvaluatorBase : IEmployeeEvaluator
{
    public Employee FindBestEmployee(IEnumerable<RatedEmployee> employees)
    {
        IEnumerable<RatedEmployee> sorted = Sort(employees);
        return sorted.First().Employee;
    }

    protected abstract IEnumerable<RatedEmployee> Sort(
        IEnumerable<RatedEmployee> employees);
}