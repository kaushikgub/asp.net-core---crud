using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }

        public string details { get; set; }
    }
}
