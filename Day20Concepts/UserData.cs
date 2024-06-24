using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Concepts
{
    public class UserData
    {
        public static List<User> GetUSers()
        {
            var users = new List<User>()
            {
                new User(){Id = 1,UserName = "Admin",Password = "Admin"},
                new User(){Id = 1,UserName = "UserA",Password = "UserA"},
                new User(){Id = 1,UserName = "UserB",Password = "UserB"},
                new User(){Id = 1,UserName = "UserC",Password = "UserC"}
            };

            return users;
        }
    }
}
