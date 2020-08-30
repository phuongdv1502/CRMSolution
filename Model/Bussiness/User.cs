using Common.Common;
using Model.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
   public class User
    {
        CRMDataContext db = null;
        public User()
        {
            db = new CRMDataContext();
        }
        public sys_user Login(string username)
        {
            try
            {
                var result = db.sys_user.FirstOrDefault(x => x.username == username);
                return result;
            }
            catch (Exception ex)
            {
                Common.Common.Util.write_log(ex.Message.ToString(), "sys_user_log.txt");
                return null;
            }
        }
    }
}
