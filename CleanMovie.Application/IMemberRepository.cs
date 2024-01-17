using CleanMovie.Domain;

namespace CleanMovie.Application
{
    public interface IMemberRepository
    {
        List<Member> GetAllMember();
        Member CreateMember(Member member);
        bool Delete(int memberId);
        /*Member GetById(int MemberId);
        Member Update(Member member);*/   
    }
}
