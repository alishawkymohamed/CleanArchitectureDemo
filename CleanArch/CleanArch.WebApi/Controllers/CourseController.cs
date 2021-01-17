using CleanArch.Application.Interfaces;
using CleanArch.Domain.Core;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArch.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            this._courseService = courseService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {
            return Ok(await this._courseService.GetCourses());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUpdateCourseViewModel model)
        {
            await this._courseService.Create(model);
            return Ok(model);
        }
    }
}
