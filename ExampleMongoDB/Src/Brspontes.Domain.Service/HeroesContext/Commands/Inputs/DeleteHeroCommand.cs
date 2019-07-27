using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using FluentValidator;
using FluentValidator.Validation;
using MongoDB.Bson;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Inputs
{
    public class DeleteHeroCommand : Notifiable, ICommands
    {
        public DeleteHeroCommand(string id)
        {
            Id = ObjectId.Parse(id);
        }

        public ObjectId Id { get; set; }

        public void Valid()
        {
            AddNotifications(new ValidationContract().Requires()
                .IsNotNullOrEmpty(Id.ToString(), "Id", "Value can not null"));
        }
    }
}
