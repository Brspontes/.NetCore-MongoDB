using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Outputs
{
    public class DeleteHeroCommandResult : ICommandResult
    {
        public string Message { get; set; }
        public bool Sucess { get; set; }
    }
}
