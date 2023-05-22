using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface IMemberRepository : IAsyncRepository<Members>
    {
    }
}