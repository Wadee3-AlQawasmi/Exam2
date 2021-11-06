using Exam2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
  public  interface IEmployeeService
    {
        public List<Country> LoadCountry();

        void InsertRecord(VmEmployee emp);

        void Delete(int ID);
    }
}
