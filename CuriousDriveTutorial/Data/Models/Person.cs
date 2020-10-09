using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriousDriveTutorial.Data.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Required]public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]public string Address { get; set; }

    }
}
