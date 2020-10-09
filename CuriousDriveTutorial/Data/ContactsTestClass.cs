using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CuriousDriveTutorial.Data
{
    public class ContactsTestClass
    {
        public int SrNumber { get; set; }
        public string ContactTitle { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactCompany { get; set; }
        public int ContactNumbers { get; set; }
        public EmailAddressAttribute ContactEmail { get; set; }
        public string ContactAddress { get; set; }
        public string ContactGPS { get; set; }
    }
}
