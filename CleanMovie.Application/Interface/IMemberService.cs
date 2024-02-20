using CleanMovie.Application.Contract.Dto.Movies;
using CleanMovie.Application.Contract.Dto.NewFolder;
using CleanMovie.Domain;

namespace CleanMovie.Application.Interface
{
    public interface IMemberService
    {
        Member Update(Member member);
        List<Member> GetAll();
        Member Create(Member member);
        bool Delete(int memberId);
        Member GetById(int memberId);
    }
}
