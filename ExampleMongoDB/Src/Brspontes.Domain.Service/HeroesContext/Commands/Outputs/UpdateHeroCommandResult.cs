using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Outputs
{
    public class UpdateHeroCommandResult : ICommandResult
    {
        public string Message { get; set; }
        public bool Sucess { get; set; }
    }
}
