using System.Threading.Tasks;

namespace AllocationsServer
{
    public interface IProjectClient
    {
        Task<ProjectInfo> Get(long projectId);
    }
}