using System;
using System.Collections.Generic;

namespace PMS.MVM.Model
{
    public class  Users
    {
        public static Dictionary<string, string> UserList { get; private set; } = new Dictionary<string, string>
        {
            { "admin", "12345" },
            { "user1", "00000" },
            { "user2", "11111" }
        };

        public static bool UpdatePassword(string username, string newPassword)
        {
            if (UserList.ContainsKey(username))
            {
                UserList[username] = newPassword;
                return true;
            }
            return false;
        }
    }
}
