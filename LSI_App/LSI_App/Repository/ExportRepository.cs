using LSI_App.Models;
using LSI_App.Repository.IRepository;
using LSI_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSI_App.Repository
{
    public class ExportRepository : IExportRepository
    {
        private readonly AppDbContext _context;

        public ExportRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Export> GetExports()
        {
            return _context.Exports.ToList();
        }

    }
}
