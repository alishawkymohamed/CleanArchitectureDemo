using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult GetCourses()
        {
            return Ok(this._courseService.GetCourses());
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUpdateCourseViewModel model)
        {
            this._courseService.Create(model);
            return Ok(model);
        }
    }
}
