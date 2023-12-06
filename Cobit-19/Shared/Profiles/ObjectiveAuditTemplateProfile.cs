﻿using AutoMapper;
using Cobit_19.Data.Models;
using Cobit_19.Shared.Dtos;


namespace Cobit_19.Shared.Profiles
{
    public class ObjectiveAuditTemplateProfile : Profile
    {
        public ObjectiveAuditTemplateProfile()
        {
            CreateMap<ObjectiveAuditTemplateModel, ObjectiveAuditTemplateDto>().ReverseMap();
        }
    }
}
