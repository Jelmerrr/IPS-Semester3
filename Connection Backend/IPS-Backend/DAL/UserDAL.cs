using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IPS_Backend.DataModels;

namespace IPS_Backend.DAL
{
    public class UserDAL
    {
        public List<DataModels.User> GetUsers()
        {
            using Context myContext = new Context();
            var Users = myContext
            .Users
            .ToList();
            return Users;
        }

        public void CreateUser(string _userName, string _userPass)
        {
            using Context myContext = new Context();
            myContext.Users.Add(new User()
            {
                userName = _userName,
                userPass = _userPass
            }
            ) ;
            myContext.SaveChanges();
        }
    }
}
