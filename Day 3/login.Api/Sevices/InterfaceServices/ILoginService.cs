using MissionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionServices.InterfaceServices
{
    public interface ILoginService
    {
        User login(string EmailAddress, string Password);
        User register(User user);
    }
}
