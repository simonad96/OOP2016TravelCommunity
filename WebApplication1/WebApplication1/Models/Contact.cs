using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Contact
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
     

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Phone> Phones {get; set;}
    }
}