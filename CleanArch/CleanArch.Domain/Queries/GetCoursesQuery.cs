using CleanArch.Domain.Core.Queries;
using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Domain.Queries
{
    public class GetCoursesQuery : Query<IEnumerable<Course>>
    {
        public GetCoursesQuery()
        {

        }
    }
}
