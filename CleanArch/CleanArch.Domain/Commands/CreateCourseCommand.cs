namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string description, string imageUrl)
        {
            base.Name = name;
            base.Description = description;
            base.ImageUrl = imageUrl;
        }
    }
}
