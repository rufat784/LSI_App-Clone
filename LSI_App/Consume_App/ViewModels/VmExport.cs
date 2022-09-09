using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consume_App.ViewModels
{
    public class VmExport
    {
        public Guid Id { get; set; }
        public string ExportName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public string LocalName { get; set; }
    }
}
