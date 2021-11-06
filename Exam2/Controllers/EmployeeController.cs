using Exam2.Data;
using Exam2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeService employeeService;
        public EmployeeController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }
        public IActionResult Index()
        {
            List<Employee> List = new List<Employee>();
            List<Country> List1 = employeeService.LoadCountry();
            VmEmployee vm = new VmEmployee();
            vm.LiCounrty = List1;
            vm.LiEmployee = List;
            return View("EmployeeView",vm);
        }

        public IActionResult SaveData(VmEmployee emp)
        {
           
             string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "path1", emp.employee.Image.FileName);
            emp.employee.Image.CopyTo(new FileStream(FilePath, FileMode.Create));
            emp.employee.Path = "http://localhost/Exam2/Upload/" + emp.employee.Image.FileName;
            List<Country> List1 = employeeService.LoadCountry();

            employeeService.InsertRecord(emp);
            VmEmployee vm = new VmEmployee();
            vm.LiCounrty = List1;
            List<Employee> List = new List<Employee>();
            vm.LiEmployee = List;
            return View("EmployeeView",vm);
        }

        public IActionResult Delete(int ID)
        {

            return View("EmployeeView");
        }
    }
}
