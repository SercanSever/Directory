using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public int ContactId { get; set; }
        public string ContactLocation { get; set; }
    }
}
