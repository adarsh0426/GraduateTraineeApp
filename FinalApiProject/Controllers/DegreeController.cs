using Microsoft.AspNetCore.Mvc;

namespace FinalApiProject.Data
{
    [Route("api/[controller]/")]
    [ApiController]
    public class DegreeController : Controller
    {
        private readonly IDegreeRepository _degreeRepository;

        public DegreeController(IDegreeRepository degreeRepository)
        {
            _degreeRepository = degreeRepository;
        }

        [HttpGet]
        public IActionResult GetAllDegrees()
        {
            var degrees = _degreeRepository.GetDegrees();
            return Ok(degrees);
        }
    }
}
