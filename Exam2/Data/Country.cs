using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Data
{
    [Table("Countries")]
    public class Country
    {
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }

        List<Employee> LiEmployee { set; get; }
    }
}
