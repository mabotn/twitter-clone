using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application.Services
{
    class Accounts
    {
        public static Models.Account Login()
        {
            return new Models.Account();
        }

        public static Models.Account Register()
        {
            return new Models.Account();
        }

        public static Models.Account GetAccount(int Id)
        {
            return new Models.Account();
        }
    }
}
