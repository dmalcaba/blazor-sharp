using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Playground.Models
{
    public class Employee
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsTerminated { get; set; }
    }
}
