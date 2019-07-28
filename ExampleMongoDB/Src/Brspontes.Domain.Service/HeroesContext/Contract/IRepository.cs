using Brspontes.Domain.Mongo.HeroesContext.Entities;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Inputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Outputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.QueriesResults;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.Contract
{
    public interface IRepository
    {
        RegisterHeroCommandResult Save(Heroes hero);
        UpdateHeroCommandResult Update(Heroes Hero);
        IEnumerable<GetAllQueryResult> Get();
        GetByIdQueryResult Get(ObjectId id);
        DeleteHeroCommandResult Remove(ObjectId id);
    }
}
