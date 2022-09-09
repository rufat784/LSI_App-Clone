using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LSI_App.Models
{
    public class Export
    {
        [Key]
        public Guid Id { get; set; }
        public string ExportName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public string LocalName { get; set; }
    }
}
