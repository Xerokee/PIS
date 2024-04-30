using Microsoft.EntityFrameworkCore.ChangeTracking;
using PIS.DAL.DataModel;
using PIS.Model;
using PIS.Repository.Automapper;
using PIS.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS.Repository
{
    public class Repository : IRepository
    {
        private readonly PIS_DbContext appDbContext;
        private IRepositoryMappingService _mapper;

        public Repository(PIS_DbContext appDbContext, IRepositoryMappingService mapper)
        {
            this.appDbContext = appDbContext;
            _mapper = mapper;
        }
        public string Test()
        {
            return "I am OK - Repository.";
        }
        public IEnumerable<UsersDomain> GetAllUsers()
        {
            IEnumerable<PisUsersMmargeta> usersDb = appDbContext.PisUsersMmargeta.ToList();

            IEnumerable<UsersDomain> usersDomain = _mapper.Map<IEnumerable<UsersDomain>>(usersDb);
            return usersDomain;
        }

        public IEnumerable<PisUsersMmargeta> GetAllUsersDb()
        {
            IEnumerable<PisUsersMmargeta> userDb = appDbContext.PisUsersMmargeta.ToList();
            return userDb;
        }
        public UsersDomain GetUserDomainByUserId(int userId)
        {
            PisUsersMmargeta userDb = appDbContext.PisUsersMmargeta.Find(userId);

            UsersDomain user = _mapper.Map<UsersDomain>(userDb);

            return user;
        }
        public async Task<bool> AddUserAsync(UsersDomain userDomain)
        {
            try
            {
                EntityEntry<PisUsersMmargeta> user_created = await appDbContext.PisUsersMmargeta.AddAsync(
                        _mapper.Map<PisUsersMmargeta>(userDomain));
                await appDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> UpdateUserOibAsync(UsersDomain userDomain)
        {
            try
            {
                PisUsersMmargeta userDb = appDbContext.PisUsersMmargeta.Find(userDomain.UserId);

                if (userDb == null)
                {
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
