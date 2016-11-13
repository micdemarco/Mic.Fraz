using System.Threading.Tasks;
using Mic.Fraz.BusinessInterfaces;
using Mic.Fraz.Domain;
using Mic.Fraz.RepositoryInterfaces;

namespace Mic.Fraz.Business
{
    public class UserManager: IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetAsync(int id)
        {
            return await _userRepository.GetAsync(id);
        }
    }
}
