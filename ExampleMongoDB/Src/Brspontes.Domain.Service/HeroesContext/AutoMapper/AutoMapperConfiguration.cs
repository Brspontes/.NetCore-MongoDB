﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new MappingsProfiles());
            });
        }
    }
}
