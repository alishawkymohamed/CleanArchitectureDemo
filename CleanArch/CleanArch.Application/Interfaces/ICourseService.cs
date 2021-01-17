using CleanArch.Domain.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseViewModel>> GetCourses();
        Task Create(CreateUpdateCourseViewModel model);
    }
}
