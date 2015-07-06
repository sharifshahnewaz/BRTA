using System;
using System.Collections.Generic;
using System.Text;

namespace BrtaModel
{
    public class User : EntityBase
    {
        private string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       

        public bool  Post()
        {
            throw new NotImplementedException();
        }

        public User SelectUser(string userId)
        {
            throw new NotImplementedException();
        }

        public List<User> SelectAll()
        {
            try
            {
                List<User> oUserList = new List<User>();

                User oUser = new User();
                oUser.Id = 1;
                oUser.name = "Admin";
                oUser.password = "Admin";
                oUser.type = "Administrator";
                oUser.userId = "Admin";
                oUserList.Add(oUser);

                oUser = new User();
                oUser.Id = 2;
                oUser.name = "User";
                oUser.password = "User";
                oUser.type = "User";
                oUser.userId = "User";
                oUserList.Add(oUser);

                return oUserList;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }

    

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
