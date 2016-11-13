using Mic.Fraz.Domain;
using System.Threading.Tasks;

namespace Mic.Fraz.RepositoryInterfaces
{
    public interface IUserRepository
    {
        Task<User> GetAsync(int id);
    }
}
