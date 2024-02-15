using CleanMovie.Application.Contract.Dto.Movies;
using CleanMovie.Application.Interface;
using CleanMovie.Domain;

namespace CleanMovie.Application.Implementation
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public Member Create(Member member)
        {
            _memberRepository.CreateMember(member);
            return member;
        }

        public List<Member> GetAll()
        {
            return _memberRepository.GetAllMember();
        }
        public bool Delete(int memberId)
        {
            var deleteMember = _memberRepository.Delete(memberId);
            return deleteMember;
        }
        public Member GetById(int MemberId)
        {
            return _memberRepository.GetById(MemberId);
        }

        public Member Update(Member member)
        {
            return _memberRepository.Update(member);
        }
    }
}
