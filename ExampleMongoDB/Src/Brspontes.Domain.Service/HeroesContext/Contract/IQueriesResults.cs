using Brspontes.Domain.Service.Mongo.HeroesContext.QueriesResults;
using MongoDB.Bson;
using System.Collections.Generic;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.Contract
{
    public interface IQueriesResults
    {
        IEnumerable<GetAllQueryResult> Get();
        GetByIdQueryResult GetById(ObjectId id);
    }
}
