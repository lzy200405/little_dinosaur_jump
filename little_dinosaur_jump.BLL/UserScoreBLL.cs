using little_dinosaur_jump.DAl;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace little_dinosaur_jump.BLL
{
    public class UserScoreBLL
    {
        private UserScoreDAL userScoreDAl = new UserScoreDAL();

        public List<Score> GetAll()
        {
            return userScoreDAl.QueryAll();
        }

        public bool UpdateScore(Score score)
        {
            return userScoreDAl.WriteHighestScore(score) > 0 ? true : false;
        }
    }
}
