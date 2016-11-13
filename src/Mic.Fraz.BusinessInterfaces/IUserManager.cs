using Mic.Fraz.Domain;
using System.Threading.Tasks;

namespace Mic.Fraz.BusinessInterfaces
{
    public interface IUserManager
    {
        Task<User> GetAsync(int id);
    }
}
