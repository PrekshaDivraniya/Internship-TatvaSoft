using MissionEntities.Entities;
using MissionRepositories.InterfaceRepo;
using MissionServices.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissionServices.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public User login(string EmailAddress, string Password)
        {
            return this._loginRepository.login(EmailAddress, Password);
        }

        public User register(User user)
        {
            return this._loginRepository.register(user);
        }
    }
}
