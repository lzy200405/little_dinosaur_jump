using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using little_dinosaur_jump.DAl;

namespace little_dinosaur_jump.BLL
{
    public class StoreBLL
    {
        private StoreDAL storeDAL=new StoreDAL();

        //查询积分
        public int QueryMoney(string username)
        { return storeDAL.QueryMoney(username); }

        //查询复活币
        public int QueryCoin(string username)
        { return storeDAL.QueryCoin(username); }

        //购买复活币
        public bool BuyCoin(string username,int num)
        {
            return storeDAL.BuyCoin(username,num);
        }

        //分数转积分
        public bool GetMoney(string username, int num)
        {
            return storeDAL.GetMoney(username, num);
        }

        //使用复活币
        public bool UseCoin(string username)
        {
            return storeDAL.UseCoin(username);
        }

    }
}
