using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public class SystemMessage
    {
        public class MessageLogin
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }

            public List<LstRoleUser> lstRLU { get; set; }
        }
        public class LstRoleUser
        {
            public int id { get; set; }
            public string name { get; set; }

        }
    }
}
