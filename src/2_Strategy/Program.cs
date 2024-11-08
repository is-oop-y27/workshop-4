﻿using AutoBogus;
using Bogus;
using Strategy.Models;
using Strategy.Services;
using Strategy.Sorting;

Randomizer.Seed = new Random(52);

var sorter = new TaskEmployeeSorter();

var evaluator = new EmployeeEvaluator(sorter);
var qualifier = new EmployeePromotionQualifier(sorter, 5);

RunScenario(evaluator);

return;

static void RunScenario(IEmployeeEvaluator evaluator)
{
    const int employeeCount = 10;

    List<Employee> employees = new AutoFaker<Employee>().Generate(employeeCount);
    List<EmployeeRating> employeeRatings = new AutoFaker<EmployeeRating>().Generate(employeeCount);

    RatedEmployee[] ratedEmployees = employees
        .Zip(employeeRatings)
        .Select(tuple => new RatedEmployee(tuple.First, tuple.Second))
        .ToArray();

    Console.WriteLine("Employees:");
    Console.WriteLine(string.Join("\n", ratedEmployees.Select(x => x.ToString())));
    Console.WriteLine();

    Employee bestEmployee = evaluator.FindBestEmployee(ratedEmployees);

    Console.WriteLine("Best employee:");
    Console.WriteLine(bestEmployee);
}