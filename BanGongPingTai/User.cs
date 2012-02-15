using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BanGongPingTai
{
    public class User
    {
        private User() { }
        private static User currentUser;

        public static User CurrentUser
        {
            get
            {
                if (currentUser == null)
                    currentUser = new User();
                return currentUser;
            }
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }

        public void UpdatePassword(string newPassword)
        {
            UsersDataSetTableAdapters.UsersTableAdapter tableAdapter = new UsersDataSetTableAdapters.UsersTableAdapter();
            tableAdapter.UpdatePassword(newPassword, currentUser.UserName);

            currentUser.Password = newPassword;
        }
    }
}
