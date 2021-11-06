using Exam2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class EmployeeService:IEmployeeService
    {
        CompanyContext companyContext;
        public EmployeeService(CompanyContext _companyContext)
        {
            companyContext = _companyContext;
        }
        public List<Country> LoadCountry()
        {
            List<Country> countries = (companyContext.Country).ToList();
            return countries;
        }

        public void InsertRecord(VmEmployee emp)
        {
            companyContext.Employee.Add(emp.employee);
            companyContext.SaveChanges();
        }

        public void Delete(int ID)
        {
           Employee emp= companyContext.Employee.Find(ID);
            companyContext.Employee.Remove(emp);
            companyContext.SaveChanges();
        }
    }
}
