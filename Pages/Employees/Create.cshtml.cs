using NET_CORE_9_Management_Systems.Helpers;
using NET_CORE_9_Management_Systems.Models;
using NET_CORE_9_Management_Systems.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace NET_CORE_9_Management_Systems.Pages.Employees
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public EmployeeViewModel? EmployeeViewModel { get; set; }
        public void OnGet()
        {
            this.EmployeeViewModel = new EmployeeViewModel
            {
                Employee = new Employee(),
                Departments = DepartmentsRepository.GetDepartments()
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelStateHelper.GetErrors(this.ModelState);

                return RedirectToPage("/Errors", new { errors });
            }
            if (this.EmployeeViewModel is not null && EmployeeViewModel.Employee is not null)
            {
                EmployeesRepository.AddEmployee(this.EmployeeViewModel.Employee);
            }
            return RedirectToPage("Index");
        }
    }//end Create PageModel
}

