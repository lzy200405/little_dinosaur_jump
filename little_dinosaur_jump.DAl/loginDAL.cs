using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace little_dinosaur_jump.DAl
{
    public class loginDAL
    {
        public Login QueryLoginInfo(string username)
        {
            DbContext dbContext = new MyDbContext();
            Login loginInfo = dbContext.Set<Login>().Where(data => data.User_name == username).FirstOrDefault();
            return loginInfo;
        }

        //查询用户
        public Login QueryLoginInfo(string username, string password)
        {
            DbContext dbContext = new MyDbContext();
            Login loginInfo = dbContext.Set<Login>().Where(data => data.User_name == username && data.Password == password).FirstOrDefault();
            return loginInfo;
        }

        //注册用户
        public int RegistLogInfo(Login login)
        {
            DbContext dbContext = new MyDbContext();
            dbContext.Set<Login>().AddOrUpdate(login);
            return dbContext.SaveChanges();
        }
    }
}
