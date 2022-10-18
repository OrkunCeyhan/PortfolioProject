using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        [StringLength(50)]
        public string ServiceName { get; set; }
        public bool IsActive { get; set; }
    }
}
