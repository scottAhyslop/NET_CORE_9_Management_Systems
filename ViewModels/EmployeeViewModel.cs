using NET_CORE_9_Management_Systems.Models;



namespace NET_CORE_9_Management_Systems.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee? Employee { get; set; }
        public List<Department>? Departments { get; set; }
    }
}
