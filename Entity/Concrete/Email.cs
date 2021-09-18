using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Email
    {
        [Key]
        public int EmailId { get; set; }
        public int ContactId { get; set; }
        public string ContactEmail { get; set; }
        public Contact Contact { get; set; }
    }
}
