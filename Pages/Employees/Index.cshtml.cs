using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NET_CORE_9_Mangement_Systems.Models;

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
            new Employee(1,"Ozzy","Osbourne", "Membranophone Specialist","Vocals", 500000),
            new Employee(2,"Tony", "Iommi", "Guitar Player", "Guitars", 500000),
            new Employee(3,"Geezer", "Butler", "Bass Player", "Guitars", 500000),
            new Employee(4,"Bill", "Ward", "Bongos", "Percussion", 500000),
            };

        #endregion
        public void OnGet()
        {
        }
    }
}
