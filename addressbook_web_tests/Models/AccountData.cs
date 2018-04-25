using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class AccountData
    {
        public String UserName { get; set; }
        public String Password { get; set; }

        public AccountData(String userName, String password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
