using LSI_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSI_App.Repository.IRepository
{
    public interface IExportRepository
    {
        List<Export> GetExports();
    }
}
