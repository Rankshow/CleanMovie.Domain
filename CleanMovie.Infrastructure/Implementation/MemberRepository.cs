using CleanMovie.Application.Interface;
using CleanMovie.Domain;
using CleanMovie.Infrastructure.Data;

namespace CleanMovie.Infrastructure.Implementation
{
    public class MemberRepository : IMemberRepository
    {
        private readonly MovieDbContext _movieDbContext;
        public MemberRepository(MovieDbContext movieDbContext)
        {

            _movieDbContext = movieDbContext;

        }
        public Member CreateMember(Member member)
        {
            _movieDbContext.Members.Add(member);
            _movieDbContext.SaveChanges();
            return member;
        }

        public List<Member> GetAllMember()
        {
            return _movieDbContext.Members.ToList();
        }
        public bool Delete(int memberId)
        {
            var deleteMember = _movieDbContext.Members.FirstOrDefault(x => x.MemberId == memberId);
            _movieDbContext.Members.Remove(deleteMember ?? new Member());
            _movieDbContext.SaveChanges();
            return true;
        }


        /*public Member GetById(int memberId)
        {
            var getMemberId = _movieDbContext.Members.FirstOrDefault( x => x.MemberId == MemberId );
            _movieDbContext.SaveChanges();
            return getMemberId ?? new Member();

        }

        public Member Update(Member member)
        {
            var update = _movieDbContext.Members.FirstOrDefault( x => x.Equals(member) );
            _movieDbContext.Update(member);
            return update ?? new Member();
        }*/
    }
}
