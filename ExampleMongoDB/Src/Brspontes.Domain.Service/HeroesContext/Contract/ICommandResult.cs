namespace Brspontes.Domain.Service.Mongo.HeroesContext.Contract
{
    public interface ICommandResult
    {
        string Message { get; set; }
        bool Sucess { get; set; }
    }
}
