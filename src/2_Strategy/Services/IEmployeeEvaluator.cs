using Strategy.Models;

namespace Strategy.Services;

public interface IEmployeeEvaluator
{
    Employee FindBestEmployee(IEnumerable<RatedEmployee> employees);
}