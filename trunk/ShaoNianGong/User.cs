using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShaoNianGong
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
        public int UserType { get; set; }
    }
}
