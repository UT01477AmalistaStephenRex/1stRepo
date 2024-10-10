using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Database;
using WebApplication1.DTO.BookCategories;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly MembersRepo _membersRepo;

        public MembersController(MembersRepo membersRepo)
        {
            _membersRepo = membersRepo;
        }

        [HttpGet]

        public IActionResult Getall()
        {
            var members = _membersRepo.GetAll();
            return Ok(members);
        }

        //[HttpGet("{MemberId}")]
        //public IActionResult GetById(int MemberId)
        //{
        //    var members = _membersRepo.GetById(MemberId);
        //    if (members == null)
        //        return NotFound();
        //    return Ok(members);
        //}
    }
}
