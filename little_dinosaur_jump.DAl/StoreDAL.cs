using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_dinosaur_jump.DAl
{
    public class StoreDAL
    {

        //查询用户的积分
        public int QueryMoney(string username)
        {
            DbContext dbContext = new MyDbContext();
            Store store = dbContext.Set<Store>().Where(data => data.User_Name == username).FirstOrDefault();
            if (store == null)
            {
                Store newstore = new Store();
                newstore.User_Name = username; ;
                newstore.Money = 0;
                dbContext.Set<Store>().AddOrUpdate(newstore);
                store = newstore;
            }
            dbContext.SaveChanges(); // 保存更改

            return store.Money;
        }


        //查询用户的复活币
        public int QueryCoin(string username)
        {
            DbContext dbContext = new MyDbContext();
            Store store = dbContext.Set<Store>().Where(data => data.User_Name == username).FirstOrDefault();
            if (store == null)
            {
                Store newstore = new Store();
                newstore.User_Name = username; ;
                newstore.Money = 0;
                dbContext.Set<Store>().AddOrUpdate(newstore);
                store = newstore;
            }
            dbContext.SaveChanges(); // 保存更改

            return store.CoinNum;
        }

        //购买复活币
        public bool BuyCoin(string username, int num)
        {
            DbContext dbContext = new MyDbContext();
            Store store = dbContext.Set<Store>().Where(data => data.User_Name == username).FirstOrDefault();
            if (store == null)
            {
                Store newstore = new Store();
                newstore.User_Name = username; ;
                newstore.Money = 0;
                dbContext.Set<Store>().AddOrUpdate(newstore);
                store = newstore;
            }
            dbContext.SaveChanges(); // 保存更改
            if (store.Money - num * 100 > 0)
            {
                store.Money -= num * 100;
                store.CoinNum = +num;
                dbContext.Set<Store>().AddOrUpdate(store);
                dbContext.SaveChanges(); // 保存更改
                return true;
            }
            else { return false; }

        }

        //分数转积分
        public bool GetMoney(string username, int num)
        {
            DbContext dbContext = new MyDbContext();
            Store store = dbContext.Set<Store>().Where(data => data.User_Name == username).FirstOrDefault();
            num = num / 10;
            store.Money += num;
            dbContext.Set<Store>().AddOrUpdate(store);
            dbContext.SaveChanges(); // 保存更改
            return true;
        }

        //使用复活币
        public bool UseCoin(string username)
        {
            DbContext dbContext = new MyDbContext();
            Store store = dbContext.Set<Store>().Where(data => data.User_Name == username).FirstOrDefault();
            if (store == null)
            {
                Store newstore = new Store();
                newstore.User_Name = username; ;
                newstore.Money = 0;
                dbContext.Set<Store>().AddOrUpdate(newstore);
                store = newstore;
            }
            dbContext.SaveChanges(); // 保存更改
            if (store.CoinNum < 1)
            {
                return false;
            }
            else
            {
                store.CoinNum -= 1;
                dbContext.Set<Store>().AddOrUpdate(store);
                dbContext.SaveChanges(); // 保存更改
                return true;
            }

        }
    }
}
