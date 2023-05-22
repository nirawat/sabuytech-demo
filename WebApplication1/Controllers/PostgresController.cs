using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostgresController : ControllerBase
    {
        private readonly IMemberRepository _memberRepository;
        public PostgresController(IMemberRepository memberRepository) 
        {
            _memberRepository = memberRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Members>>> GetMembers()
        {
            var data = await _memberRepository.ListAllAsync();
            return Ok(data);
        }
    }
}
