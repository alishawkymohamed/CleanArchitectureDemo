using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            this._courseRepository = courseRepository;
            this._bus = bus;
        }

        public void Create(CreateUpdateCourseViewModel model)
        {
            var creatCourseCommand = new CreateCourseCommand(model.Name, model.Description, model.ImageUrl);
            this._bus.SendCommand(creatCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel
            {
                Courses = this._courseRepository.GetCourses()
            };
        }
    }
}