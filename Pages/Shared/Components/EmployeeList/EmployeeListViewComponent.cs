using Microsoft.AspNetCore.Mvc;
using NET_CORE_9_Management_Systems.Models;

namespace NET_CORE_9_Management_Systems.Pages.Shared.Components.EmployeeList
{
    public class EmployeeListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string? filter, int? departmentId)
        {
            //get a list of sample test _employees from the repository based on filter and return them to the View

            return View(EmployeesRepository.GetEmployees(filter, departmentId));

        } //end Invoke (i.e. GetEmployees)
    }//end EmployeeListViewComponent
}//end namespace

