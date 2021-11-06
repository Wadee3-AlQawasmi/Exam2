using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.Data
{
    [Table("Employees")]
    public class Employee
    {
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }
        public int phone { set; get; }
        public string Email { set; get; }
        public DateTime? BirthDate { set; get; }

        public string Path { set; get; }
        [NotMapped]
        public IFormFile Image { set; get; }

        [ForeignKey("country")]
        public int Country_ID { set; get; }
        public Country country { set; get; }

    }
}
