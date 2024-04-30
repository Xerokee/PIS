﻿using PIS.DAL.DataModel;
using PIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS.Repository.Common
{
    public interface IRepository
    {
        IEnumerable<UsersDomain> GetAllUsers();
        IEnumerable<PisUsersMmargeta> GetAllUsersDb();
        UsersDomain GetUserDomainByUserId(int userId);
        Task<bool> AddUserAsync(UsersDomain userDomain);
        string Test();
    }
}