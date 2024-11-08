using Strategy.Models;

namespace Strategy.Sorting;

public interface IEmployeeSorter
{
    IOrderedEnumerable<RatedEmployee> Sort(IEnumerable<RatedEmployee> employees);
}