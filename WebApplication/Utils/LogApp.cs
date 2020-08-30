using Model.Ef;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication
{
    public class LogApp
    {
        CRMDataContext db = new CRMDataContext();
        public void WriteDbLog(sys_log entiSysLog)
        {
            entiSysLog.date = DateTime.Now;
            entiSysLog.account = Env.GetUserInfo("name");
            entiSysLog.ipAddress = Common.Common.Net.Ip;
            entiSysLog.creatorTime = DateTime.Now;
            entiSysLog.creatorUserId = Convert.ToInt32(Env.GetUserInfo("userid"));
            Insert(entiSysLog);

        }



        private void Insert(sys_log entiSysLog)
        {
            db.Entry(entiSysLog).State = EntityState.Added;
            db.SaveChanges();
        }
    }
}