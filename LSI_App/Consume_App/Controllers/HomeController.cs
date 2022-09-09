using Consume_App.Helpers.Api;
using Consume_App.Models;
using Consume_App.Repository.IRepository;
using Consume_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Consume_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExportRepository _exportRepository;

        public HomeController(IExportRepository exportRepository)
        {
            _exportRepository = exportRepository;
        }

        public async Task<IActionResult> Index()
        {

            List<VmExport> vmExports = await _exportRepository.GetExports(SD.ApiPathExport);
            var exports = vmExports.OrderBy(x => x.LocalName).ToList();

            return View(exports);
        }

        [HttpPost]
        public async Task<IActionResult> Index(string search, DateTime startDate, DateTime endDate)
        {

            List<VmExport> exports = await _exportRepository.GetExports(SD.ApiPathExport);

            var userSearch = exports.Where(ex => (search != null ? ex.LocalName.Contains(search) : true)||
                                                 (ex.CreatedDate >= startDate) &&
                                                 (ex.CreatedDate <= endDate));

            List<VmExport> exportFinal = userSearch.OrderBy(r => r.LocalName).ToList();

            return View(exportFinal);
        }
    }
}
