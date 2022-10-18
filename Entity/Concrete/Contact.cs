using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(40)]
        public string SenderName { get; set; }
        [StringLength(75)]
        public string SenderMail { get; set; }
        [StringLength(250)]
        public string SenderMessage { get; set; }


    }
}
