using System.Threading.Tasks;

namespace BacklogServer
{
    public interface IProjectClient
    {
        Task<ProjectInfo> Get(long projectId);
    }
}