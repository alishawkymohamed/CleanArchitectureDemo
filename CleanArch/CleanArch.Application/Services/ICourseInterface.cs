using CleanArch.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArch.Application.Services
{
    public interface ICourseInterface
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
