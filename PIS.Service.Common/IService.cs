﻿using PIS.DAL.DataModel;
using PIS.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PIS.Service.Common
{
    public interface IService
    {
        string Test();
        IEnumerable<UsersDomain> GetAllUsers();
        IEnumerable<PisUsersMmargeta> GetAllUsersDb();
        UsersDomain GetUserDomainByUserId(int userId);
        Task<bool> AddUserAsync(UsersDomain userDomain);
    }
}