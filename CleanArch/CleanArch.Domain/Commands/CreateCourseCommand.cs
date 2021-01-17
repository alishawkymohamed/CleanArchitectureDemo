using CleanArch.Domain.Core.Commands;

namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand : Command<bool>
    {
        public CreateCourseCommand(string name, string description, string imageUrl)
        {
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }

        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}
