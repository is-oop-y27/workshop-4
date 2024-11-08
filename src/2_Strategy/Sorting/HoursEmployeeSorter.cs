using Strategy.Models;

namespace Strategy.Sorting;

public class HoursEmployeeSorter : IEmployeeSorter
{
    public IOrderedEnumerable<RatedEmployee> Sort(IEnumerable<RatedEmployee> employees)
    {
        return employees
            .OrderByDescending(x => x.Rating.HoursWorked);
    }
}