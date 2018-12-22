using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManageDAL
{
    public class Project
    {
        public int ProjectId { get; set; }
        [Required]
        public int SalesOrder { get; set; }
        [Required]
        public string Reseller { get; set; }
        [Required]
        public string Customer { get; set; }
        public string Product { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public bool Complete { get; set; }

    }
}