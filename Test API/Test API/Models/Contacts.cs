using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_API.Models
{
    public class Contacts
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contacts()
        {
            ContactID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }
}