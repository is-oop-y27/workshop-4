using TemplateMethod.Models;

namespace TemplateMethod.Services;

public class HoursEmployeeEvaluator : EmployeeEvaluatorBase
{
    protected override IEnumerable<RatedEmployee> Sort(IEnumerable<RatedEmployee> employees)
    {
        return employees.OrderByDescending(x => x.Rating.HoursWorked);
    }
}