namespace Brspontes.Domain.Service.Mongo.HeroesContext.Contract
{
    public interface ICommandHandler<T> where T : ICommands
    {
        ICommandResult Handle(T command);
    }
}
