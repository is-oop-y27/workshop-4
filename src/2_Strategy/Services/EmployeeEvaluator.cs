using Strategy.Models;
using Strategy.Sorting;

namespace Strategy.Services;

public sealed class EmployeeEvaluator : IEmployeeEvaluator
{
    private readonly IEmployeeSorter _sorter;

    public EmployeeEvaluator(IEmployeeSorter sorter)
    {
        _sorter = sorter;
    }

    public Employee FindBestEmployee(IEnumerable<RatedEmployee> employees)
    {
        IOrderedEnumerable<RatedEmployee> sorted = _sorter.Sort(employees);
        return sorted.First().Employee;
    }
}