using System;
using System.Collections.Generic;
using System.Text;
using DomainModule;

namespace BusinessServiceInterface
{
    public interface IUserService
    {
        bool HaveSameUserName(String username);
        UserInfo Login(string loginName,string password);
        void Logout(UserInfo user);
        bool RegisterUser(UserInfo user);
    }
}
