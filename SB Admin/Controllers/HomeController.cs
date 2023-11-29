using Microsoft.AspNetCore.Mvc;
using SB_Admin.Service;

namespace SB_Admin.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            EmployeeService employeeService = new EmployeeService();
            var data = await employeeService.GetEmployees();
            return View(data);
        }
        public async Task<IActionResult> Tables()
        {
            EmployeeService employeeService = new EmployeeService();
            var data = await employeeService.GetEmployees();
            return View(data);
        }
    }
}
