using AutoMapper;
using Brspontes.Domain.Mongo.HeroesContext.Entities;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Inputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.QueriesResults;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.AutoMapper
{
    public class MappingsProfiles : Profile
    {
        public MappingsProfiles()
        {
            CreateMap<RegisterHeroesCommand, Heroes>();
            CreateMap<UpdateHeroesCommand, Heroes>();
            CreateMap<Heroes, GetAllQueryResult>();
            CreateMap<Heroes, GetByIdQueryResult>();
        }
    }
}
