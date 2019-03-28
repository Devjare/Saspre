using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SASPRE.Business_Layer
{
    class User
    {

        public static System.Data.DataTable Login(String nickName, String password)
        {
            var user = new Data_Layer.User()
            {
                NickName = nickName,
                Password = password
            };

            return user.Login();
        }

    }
}
