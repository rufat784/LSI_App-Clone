using AutoMapper;
using LSI_App.Dto_s;
using LSI_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSI_App.Mappings
{
    public class AppMappings : Profile
    {
        public AppMappings()
        {
            CreateMap<Export, ExportDto>().ReverseMap();
        }
    }
}
