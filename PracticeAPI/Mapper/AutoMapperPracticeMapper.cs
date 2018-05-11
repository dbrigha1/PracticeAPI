using AutoMapper;
using PracticeAPI.Models.Entity;
using PracticeAPI.Models.ViewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeAPI.Mapper
{
    public class AutoMapperPracticeMapper : Profile
    {
        public AutoMapperPracticeMapper()
        {
            CreateMap<PracticeEntity, PracticeViewEntity>()
                .ForAllMembers(opt => opt.Ignore());
            CreateMap<PracticeEntity, PracticeViewEntity>()
                .ForMember(dest => dest.PracticeName, opts => opts.MapFrom(src => src.PracticeName))
                ;

            CreateMap<PracticeViewEntity, PracticeEntity>()
                .ForAllMembers(opt => opt.Ignore());
            CreateMap<PracticeViewEntity, PracticeEntity>()
                .ForMember(dest => dest.PracticeName, opts => opts.MapFrom(src => src.PracticeName))
                .ForMember(dest => dest.PracticeId, opts => opts.MapFrom(src => 0))
                ;
        }
    }
}