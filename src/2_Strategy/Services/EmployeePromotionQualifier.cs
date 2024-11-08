using Strategy.Models;
using Strategy.Sorting;

namespace Strategy.Services;

public class EmployeePromotionQualifier : IEmployeePromotionQualifier
{
    private readonly IEmployeeSorter _sorter;
    private readonly int _quota;

    public EmployeePromotionQualifier(IEmployeeSorter sorter, int quota)
    {
        _sorter = sorter;
        _quota = quota;
    }

    public IEnumerable<Employee> Qualify(IEnumerable<RatedEmployee> employees)
    {
        return _sorter
            .Sort(employees)
            .Take(_quota)
            .Select(x => x.Employee);
    }
}