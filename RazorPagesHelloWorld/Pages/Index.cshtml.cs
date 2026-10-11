using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesHelloWorld.Models;
using RazorPagesHelloWorld.Services;
using System.Collections.Generic;

namespace RazorPagesHelloWorld.Pages;

public class IndexModel : PageModel
{
    //private readonly IEmployeeRepository employeeRepository; 

    public IEnumerable<Employee> Employees { get; set; }

    //public IndexModel(IEmployeeRepository employeeRepository)
    //{
    //    this.employeeRepository = employeeRepository; 
    //}

    public void OnGet()
    {
        var employeeRepository = new MockEmployeeRepository(); 

        Employees = employeeRepository.GetAllEmployees(); 
    }
}
