using little_dinosaur_jump.DAl;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_dinosaur_jump.BLL
{
    public class LoginBLL
    {
        private loginDAL loginDal = new loginDAL();


        //查询用户
        public bool QueryLoginInfo(string username, string password)
        {
            return loginDal.QueryLoginInfo(username, password) != null ? true : false;
        }

        //查询是否存在同名用户
        public bool QueryLoginInfo(string username)
        {
            return loginDal.QueryLoginInfo(username) != null ? true : false;
        }

        //注册
        public bool RegistLoginfo(Login login)
        {
            return loginDal.RegistLogInfo(login) > 0 ? true : false;
        }
    }
}
