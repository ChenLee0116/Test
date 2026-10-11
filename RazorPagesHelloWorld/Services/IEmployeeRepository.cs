using RazorPagesHelloWorld.Models;
using System.Collections.Generic;

namespace RazorPagesHelloWorld.Services; 

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetAllEmployees();
}
