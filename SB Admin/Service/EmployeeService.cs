using Microsoft.AspNetCore.Mvc.RazorPages;
using SB_Admin.Helpers;
using SB_Admin.ProjModels;
using System.Data;

namespace SB_Admin.Service
{
    public class EmployeeService
    {
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            DataTable datas = await SqlHelper.GetDatasAsync("SELECT * FROM GetEmployeesData");
            return datas.AsEnumerable().Select((DataRow dataRow) => new Employee()
            {
                Name = (string)dataRow["Name"],
                Position = (string)dataRow["Position"],
                Age = (int)dataRow["Age"],
                StartDate = (DateTime)dataRow["Start Date"],
                Salary = (decimal)dataRow["Salary"],
                Office = (string)dataRow["Office"]
            }).ToList();
        }
    }
}
