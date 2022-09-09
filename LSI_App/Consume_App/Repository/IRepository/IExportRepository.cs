using Consume_App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consume_App.Repository.IRepository
{
    public interface IExportRepository
    {
        Task<List<VmExport>> GetExports(string url);
    }
}
