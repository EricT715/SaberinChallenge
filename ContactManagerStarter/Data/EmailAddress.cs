using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Data
{
    public class EmailAddress : Entity
    {
        public string Email { get; set; }
        public EmailType Type { get; set; }
        // trying to feed the data someway the primary Email
        // public bool isPrimary { get; set; } 
        public virtual Contact Contact { get; set; }
    }
}
