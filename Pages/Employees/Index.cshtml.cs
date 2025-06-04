using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_CORE_9_Management_Systems.Models;

namespace NET_CORE_9_Mangement_Systems.Pages.Employees
{
    public class EmployeeModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? EmployeeId { get; set; }

        #region Sample Data
        
        //Sample data for the Employee Model
        private List<Employee> employees = new List<Employee>
            {
            new (1,"Ozzy","Osbourne", "Vocalist", 500000 ,1),
            new (2,"Tony", "Iommi", "Guitars", 500000 ,2),
            new (3,"Geezer", "Butler", "Bass", 500000,3),
            new (4,"Bill", "Ward", "Bongos", 500000, 4),
            new(5,"Robert", "Plant", "Vocalist", 500000, 1),
            new(6,"Jimmy", "Page", "Guitar Player", 500000, 2),
            new(7,"John Paul", "Jones", "Bass Player", 500000, 3),
            new(8,"John", "Bonham", "Drummer", 500000, 4),
            new(9,"Bruce", "Dickinson", "Vocalist", 500000, 1),
            new(10,"Dave", "Murray", "Guitar Player", 500000, 2),
            new(11,"Steve", "Harris", "Bass Player", 500000, 3),
            new(12,"Nicko", "McBrain", "Drummer", 500000, 4),
            new(13,"Adrian", "Smith", "Guitarist", 500000, 2)
            };


        #endregion

        public void OnGet()
        {
            //old method of populating list, now done by js filter using EmployeesByFilter method
            //this.Employees = EmployeesRepository.GetEmployees().ToList();
        }

        public IActionResult OnGetEmployeesByFilter(string? filter)
        {
            return ViewComponent("EmployeeList", new { filter });
        }
    }
}
