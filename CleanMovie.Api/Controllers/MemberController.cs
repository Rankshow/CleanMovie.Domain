using CleanMovie.Application;
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
        public ActionResult<List<Member>> GetAllMember() 
        {
            var memberFromService = _service.GetAllMember();
            return Ok(memberFromService);
        }

        [HttpPost]
        public ActionResult<Member> PostMember(Member member) 
        {
            var addMember = _service.CreateMember(member);
            return Ok(addMember);
        }

        [HttpDelete]
        [Route("{memberId:int}")]
        public ActionResult<bool> Delete(int memberId) 
        {
            var deleteMember = _service.Delete(memberId);
            return Ok(deleteMember);    
        }

        /*[HttpGet]
        [Route("{movieId}")]
        public ActionResult<bool> GetById(int MemberId) 
        {
            _service.GetById(MemberId);
            return Ok();    
        }

        [HttpPut]
        [Route("movie")]
        public ActionResult<Member> Update(Member member) 
        { 
            var update = _service.Update(member);
            return Ok(update);
        }*/
    }
}
