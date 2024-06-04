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
    public class UserScoreDAL
    {
        //查询用户
        public Score QueryScore(string username)
        {
            DbContext dbContext = new MyDbContext();
            Score score = dbContext.Set<Score>().Where(data => data.User_name == username ).FirstOrDefault();
            return score;
        }

        //更新成绩
        public int WriteHighestScore(Score score)
        {
            DbContext dbContext = new MyDbContext();
            Score Used_score = QueryScore(score.User_name);
            if(Used_score != null)
            {
                if(Used_score.Score1 < score.Score1)
                {
                    dbContext.Set<Score>().AddOrUpdate(score);
                }
            }
            else if(Used_score == null) 
            {
                dbContext.Set<Score>().AddOrUpdate(score); 
            }
            return dbContext.SaveChanges();
        }
    }
}
