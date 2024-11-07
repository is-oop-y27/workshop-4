using Strategy.Models;

namespace Strategy.Services;

public interface IEmployeePromotionQualifier
{
    IEnumerable<Employee> Qualify(IEnumerable<RatedEmployee> employees);
}