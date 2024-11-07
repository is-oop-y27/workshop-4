using TemplateMethod.Models;

namespace TemplateMethod.Services;

public interface IEmployeeEvaluator
{
    Employee FindBestEmployee(IEnumerable<RatedEmployee> employees);
}