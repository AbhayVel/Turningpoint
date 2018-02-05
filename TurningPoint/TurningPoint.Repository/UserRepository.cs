using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurningPoint.DAO;
using TurningPoint.Entities;

namespace TurningPoint.Repository
{
    public class UserRepository :IUserRepository
    {
        TurningPointContext turningPointContext;
       public UserRepository()
        {
            turningPointContext = new TurningPointContext();
        }
        public User CheckUser(String userName, String password)
        {
            var user = turningPointContext.User.Where(e => e.UserEmail == userName && e.Password == password).FirstOrDefault();
            return user;

        }
    }
}
