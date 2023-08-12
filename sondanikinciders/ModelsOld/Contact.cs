using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondanikinciders.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
        public DateTime? LastAccessed { get; set; } 
        public DateTime? CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public AuditLog AuditLog { get; set; }
    }
}
