using Brspontes.Domain.Service.Mongo.HeroesContext.Contract;
using FluentValidator;
using FluentValidator.Validation;
using MongoDB.Bson;

namespace Brspontes.Domain.Service.Mongo.HeroesContext.Commands.Inputs
{
    public class UpdateHeroesCommand : Notifiable, ICommands
    {
        public UpdateHeroesCommand(string id, string name, string superHeroName, string image, string description)
        {
            Id = ObjectId.Parse(id);
            Name = name;
            SuperHeroName = superHeroName;
            Image = image;
            Description = description;
        }

        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string SuperHeroName { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        public void Valid()
        {
            AddNotifications(new ValidationContract().Requires()
               .IsNotNullOrEmpty(Name, "Name", "Value can not null")
               .IsNotNullOrEmpty(SuperHeroName, "SuperHeroName", "Value can not null")
               .IsNotNullOrEmpty(Image, "Image", "Value can not null"));
        }
    }
}
