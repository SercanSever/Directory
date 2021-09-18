using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        public int ContactId { get; set; }
        public int ContactPhone { get; set; }
        public Contact Contact { get; set; }
    }
}
