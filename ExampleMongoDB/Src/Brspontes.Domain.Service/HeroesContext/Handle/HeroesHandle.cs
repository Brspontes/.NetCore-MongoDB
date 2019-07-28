using AutoMapper;
using Brspontes.Domain.Mongo.HeroesContext.Entities;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Inputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Outputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using Brspontes.Domain.Service.Mongo.HeroesContext.QueriesResults;
using FluentValidator;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.Handle
{
    public class HeroesHandle : Notifiable,
        ICommandHandler<RegisterHeroesCommand>,
        ICommandHandler<UpdateHeroesCommand>,
        ICommandHandler<DeleteHeroCommand>,
        IQueriesResults
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public HeroesHandle(IRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<GetAllQueryResult> Get() =>
            _mapper.Map<IEnumerable<GetAllQueryResult>>(_repository.Get());

        public GetByIdQueryResult GetById(ObjectId id) =>
            _mapper.Map<GetByIdQueryResult>(_repository.Get(id));

        public ICommandResult Handle(RegisterHeroesCommand command)
        {
            AddNotifications(command.Notifications);

            if (Invalid)
                return new RegisterHeroCommandResult
                {
                    Message = $"Please, verify informations, {Notifications}",
                    Sucess = false
                };

            return _mapper.Map<RegisterHeroCommandResult>(
                _repository.Save(_mapper.Map<Heroes>(command)));
        }

        public ICommandResult Handle(UpdateHeroesCommand command)
        {
            AddNotifications(command.Notifications);

            if (Invalid)
                return new UpdateHeroCommandResult
                {
                    Message = $"Please, verify informations, {Notifications}",
                    Sucess = false
                };

            return _mapper.Map<UpdateHeroCommandResult>(
                _repository.Update(_mapper.Map<Heroes>(command)));
        }

        public ICommandResult Handle(DeleteHeroCommand command)
        {
            AddNotifications(command.Notifications);

            if (Invalid)
                return new DeleteHeroCommandResult
                {
                    Message = $"Please, verify informations, {Notifications}",
                    Sucess = false
                };

            return _mapper.Map<DeleteHeroCommandResult>(
                _repository.Remove(command.Id));
        }
    }
}
