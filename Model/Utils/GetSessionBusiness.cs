﻿
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Model
{
    public class GetSessionBusiness
    {
        public static SessionUser GetUser()
        {
            SessionUser user = new SessionUser();
            if (HttpContext.Current.Session["session"] != null)
            {
                user = (SessionUser)HttpContext.Current.Session["session"];
            }

            return user;
        }
    }
}
