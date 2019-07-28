using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Inputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using Brspontes.Domain.Service.Mongo.HeroesContext.QueriesResults;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.Handle
{
    public class HeroesHandle :
        ICommandHandler<RegisterHeroesCommand>,
        ICommandHandler<UpdateHeroesCommand>,
        ICommandHandler<DeleteHeroCommand>,
        IQueriesResults
    {
        private readonly IRepository _repository;

        public HeroesHandle(IRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<GetAllQueryResult> Get()
        {
            throw new NotImplementedException();
        }

        public GetByIdQueryResult GetById(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handle(RegisterHeroesCommand command)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handle(UpdateHeroesCommand command)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handle(DeleteHeroCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
