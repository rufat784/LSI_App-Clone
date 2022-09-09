using AutoMapper;
using LSI_App.Dto_s;
using LSI_App.Models;
using LSI_App.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSI_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportController : ControllerBase
    {
        private readonly IExportRepository _export;
        private readonly IMapper _mapper;

        public ExportController(IExportRepository export, IMapper mapper)
        {
            _export = export;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var exports = _export.GetExports();
            List<ExportDto> dtoExports = new List<ExportDto>();

            foreach (var export in exports)
            {
                var dtoExport = _mapper.Map<Export, ExportDto>(export);

                dtoExports.Add(dtoExport);
            }
            return Ok(dtoExports);
        }
    }
}
