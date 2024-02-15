using CleanMovie.Domain;

namespace CleanMovie.Application.Interface
{
    public interface IMemberRepository
    {
        List<Member> GetAllMember();
        Member CreateMember(Member member);
        bool Delete(int memberId);
        Member GetById(int memberId);
        Member Update(Member member);
    }
}
