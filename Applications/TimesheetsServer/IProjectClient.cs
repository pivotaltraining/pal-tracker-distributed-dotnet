using System.Threading.Tasks;

namespace TimesheetsServer
{
    public interface IProjectClient
    {
        Task<ProjectInfo> Get(long projectId);
    }
}