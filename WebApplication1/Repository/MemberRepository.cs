using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class MemberRepository : BaseRepository<Members>, IMemberRepository
    {
        private readonly DbSet<Members> _members;

        public MemberRepository(EFDataContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
            _members = _appDbContext.Set<Members>();
        }
    }
}
