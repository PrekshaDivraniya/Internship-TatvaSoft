using MissionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionRepositories.InterfaceRepo
{
    public interface ILoginRepository
    {
        User login(string EmailAddress, string Password);
        User register(User user);
    }
}
