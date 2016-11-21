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

        #pragma warning disable 1998
        public async Task<User> GetAsync(int id)
        {     
            // TODO: replace with an async database operation  
            return new User()
            {
                Id = id,
                Name = $"Name-{id}-{Guid.NewGuid()}"
            };
        }
        #pragma warning restore 1998
        
    }
}

