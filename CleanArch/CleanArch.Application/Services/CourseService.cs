using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;

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

        public void Create(CreateUpdateCourseViewModel model)
        {
            var creatCourseCommand = this._mapper.Map<CreateCourseCommand>(model);
            this._bus.SendCommand(creatCourseCommand);
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return this._mapper.Map<IEnumerable<CourseViewModel>>(this._courseRepository.GetCourses());
        }
    }
}