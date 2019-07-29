using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Inputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Outputs;
using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using Brspontes.Domain.Service.Mongo.HeroesContext.Handle;
using Brspontes.Domain.Service.Mongo.HeroesContext.QueriesResults;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

namespace Brspontes.Api.Heroes.Mongo.Controller
{
    public class HeroesController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly HeroesHandle _heroesHandle;

        public HeroesController(HeroesHandle heroesHandle)
        {
            _heroesHandle = heroesHandle;
        }

        [HttpPost]
        [Route("heroes")]
        public ICommandResult AddHero([FromBody] RegisterHeroesCommand command) => 
            _heroesHandle.Handle(command);

        [HttpGet]
        [Route("heroes")]
        public IEnumerable<GetAllQueryResult> Get() => 
            _heroesHandle.Get();

        [HttpGet]
        [Route("heroes/{Id}")]
        public GetByIdQueryResult Get(string Id) => 
            _heroesHandle.GetById(ObjectId.Parse(Id));

        [HttpPut]
        [Route("heroes")]
        public ICommandResult UpdateHero([FromBody] UpdateHeroesCommand command) =>
            _heroesHandle.Handle(command);

        [HttpDelete]
        [Route("heroes")]
        public ICommandResult RemoveHero([FromBody] DeleteHeroCommand command) =>
            _heroesHandle.Handle(command);

    }
}