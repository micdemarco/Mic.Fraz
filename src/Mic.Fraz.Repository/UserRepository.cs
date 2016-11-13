using System;
using System.Threading.Tasks;
using Mic.Fraz.Domain;
using Mic.Fraz.RepositoryInterfaces;

namespace Mic.Fraz.Repository
{
    public class UserRepository: IUserRepository
    {
        public UserRepository()
        {
        }

        public async Task<User> GetAsync(int id)
        {            
            return new User()
            {
                Id = id,
                Name = $"Name-{id}-{Guid.NewGuid()}"
            };
        }
    }
}
