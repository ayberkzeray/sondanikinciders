using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondanikinciders.Models
{
    public class Order
    {
        [Key]
        public int OrderNumber { get; set; }
        public int OrderCount { get; set; }
        public DateTime DateCreated { get; set; }
        public Customer Customer { get; set; }
    }
}
