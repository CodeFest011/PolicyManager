using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrincipalMembersController : ControllerBase
    {
        private readonly DataContext _context;
        public PrincipalMembersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PrincipalMember>>> GetMembers()
        {
            var members = await _context.PrincipalMembers.ToListAsync();

            return Ok(members);
        }

        [HttpGet("{policyNo}", Name = "GetMember")]
        public async Task<ActionResult<PrincipalMember>> GetMember(string policyNo)
        {
            return await _context.PrincipalMembers.FirstAsync(u => u.PolicyNo == policyNo);
        }
    }
}