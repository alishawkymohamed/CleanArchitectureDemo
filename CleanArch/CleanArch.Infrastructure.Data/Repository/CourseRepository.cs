using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastructure.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _context;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            this._context = universityDBContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return this._context.Courses.ToList();
        }
    }
}
