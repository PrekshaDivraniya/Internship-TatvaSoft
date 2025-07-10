using MissionEntities.context;
using MissionEntities.Entities;
using MissionRepositories.InterfaceRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionRepositories.Repositories
{
    public class LoginRepository(MissionDbContext missionDbContext) : ILoginRepository
    {
        private readonly MissionDbContext _missionDbContext = missionDbContext;
        public User login(string EmailAddress, string Password)
        {
            var user = _missionDbContext.Users.Where(u => u.EmailAddress == EmailAddress && u.Password == Password).FirstOrDefault();
            if (user != null)
            {
                return user;
            }
            else
            {
                return null; // Return null if no user found
            }
        }

        public User register(User user)
        {
            var existing = _missionDbContext.Users.FirstOrDefault(u => u.EmailAddress == user.EmailAddress);
            if (existing != null)
            {
                return null;
            }
            user.CreatedDate = DateTime.UtcNow;
            user.ModifiedDate = DateTime.UtcNow;
            user.IsDeleted = false;
            _missionDbContext.Users.Add(user);
            _missionDbContext.SaveChanges();
            return user;
        }
    }
}
