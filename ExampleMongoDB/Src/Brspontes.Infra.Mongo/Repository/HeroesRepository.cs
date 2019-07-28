using Brspontes.Domain.Mongo.HeroesContext.Entities;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Outputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using Brspontes.Domain.Service.Mongo.HeroesContext.QueriesResults;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace Brspontes.Infra.Mongo.Repository
{
    public class HeroesRepository : IRepository
    {
        public GetByIdQueryResult Get(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public DeleteHeroCommandResult Remove(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public RegisterHeroCommandResult Save(Heroes hero)
        {
            throw new NotImplementedException();
        }

        public UpdateHeroCommandResult Update(Heroes hero)
        {
            throw new NotImplementedException();
        }

        IEnumerable<GetAllQueryResult> IRepository.Get()
        {
            throw new NotImplementedException();
        }
    }
}
