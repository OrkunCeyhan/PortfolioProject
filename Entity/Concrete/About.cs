using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(30)]
        public string FullName { get; set; }
        [StringLength(40)]
        public string Job { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(150)]
        public string CvLink { get; set; }
        [StringLength(75)]
        public string  Mail { get; set; }
        [StringLength(15)]
        public string  MobilePhone { get; set; }

    }
}
