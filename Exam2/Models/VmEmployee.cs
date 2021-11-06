using Exam2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Models
{
    public class VmEmployee
    {
       public List<Country> LiCounrty { set; get; }
       public List<Employee> LiEmployee { set; get; }

       public Employee employee { set; get; }
    }
}
