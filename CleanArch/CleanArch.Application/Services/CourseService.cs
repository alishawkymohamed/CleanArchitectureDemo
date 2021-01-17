using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Domain.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            this._courseRepository = courseRepository;
            this._bus = bus;
            this._mapper = mapper;
        }

        public async Task Create(CreateUpdateCourseViewModel model)
        {
            var creatCourseCommand = this._mapper.Map<CreateCourseCommand>(model);
            await this._bus.SendCommand<bool>(creatCourseCommand);
        }

        public async Task<IEnumerable<CourseViewModel>> GetCourses()
        {
            var query = new GetCoursesQuery();
            var courses = await this._bus.SendCommand<IEnumerable<Course>>(query);
            return this._mapper.Map<IEnumerable<CourseViewModel>>(courses);
        }
    }
}