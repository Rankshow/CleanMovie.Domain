using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CleanMovie.Api.Controllers
{
    [Route("api/members")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _service;
        public MemberController(IMemberService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Member>> GetAll() 
        {
            var allMovies = _service.GetAll();  
            return Ok(allMovies);
        }

        [HttpPost]
        public ActionResult<Member> Create(Member member) 
        {
            var addMember = _service.Create(member);
            return Ok(addMember);
        }

        [HttpDelete]
        [Route("{memberId:int}")]
        public ActionResult<bool> Delete(int memberId) 
        {
            var deleteMember = _service.Delete(memberId);
            return Ok(deleteMember);    
        }

        [HttpGet]
        [Route("{memberId:int}")]
        public ActionResult<bool> GetById(int memberId) 
        {
            var addId = _service.GetById(memberId);
            return Ok(addId);    
        }

        [HttpPut]
        [Route("member")]
        public ActionResult<Member> Update(Member member) 
        { 
            var update = _service.Update(member);
            return Ok(update);
        }
    }
}
