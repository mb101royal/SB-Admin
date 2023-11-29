using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Xml.Linq;

namespace SB_Admin.ProjModels
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position {  get; set; }
        public int Age { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public string Office { get; set; }
    }
}
