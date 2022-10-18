using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        [StringLength(50)]
        public string ProjectName { get; set; }
        [StringLength(150)]
        public string ProjectImgUrl { get; set; }
        [StringLength(150)]
        public string ProjectDescription { get; set; }
        public bool IsActive { get; set; }
        [StringLength(150)]
        public string ProjectLinkUrl { get; set; }
    }
}
